using Domain.Models;
using System.Net.Http.Headers;

Run().GetAwaiter().GetResult();

static async Task Run()
{
    client.BaseAddress = new Uri("https://localhost:7024");
    client.DefaultRequestHeaders.Accept.Clear();
    client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));

    try
    {
        //TestGet();

        //TestPost();

        TestPut();
    }
    catch(Exception ex)
    { 
        Console.WriteLine(ex.ToString()); 
    }
}

static async void TestPut()
{
    Produto p = await GetProduto(@"produto/27");
    Console.WriteLine(p);
    
    p.Complemento = "Tilapia";
    await UpdateProduto(p);
    Console.WriteLine(p);

    Console.WriteLine();
}

static async void TestGet()
{
    Produto produto = await GetProduto(@"produto/27");
    Console.WriteLine(produto);
    
    Console.WriteLine();
}

static async void TestPost()
{
    Produto p2 = new Produto();
    p2.Nome = "anzol";
    p2.Complemento = "pesca";
    p2.ProdutoTipo = EProdutoTipo.Revenda;
    var post1 = CreateProduto(p2);
    Console.Write(post1.Result);

    Console.WriteLine();
}

static async Task<Produto> UpdateProduto(Produto produto)
{
    HttpResponseMessage response = await client.PutAsJsonAsync($"produto/{produto.Id}", produto);
    response.EnsureSuccessStatusCode();
    produto = await response.Content.ReadAsAsync<Produto>();
    return produto;
}

static async Task<Uri> CreateProduto(Produto produto)
{
    HttpResponseMessage response = await client.PostAsJsonAsync("produto", produto);
    response.EnsureSuccessStatusCode();

    return response.Headers.Location;
}

static async Task<Produto> GetProduto(string path)
{
    Produto produto = null;
    HttpResponseMessage response = await client.GetAsync(path);
    if (response.IsSuccessStatusCode)
    {
        produto = await response.Content.ReadAsAsync<Produto>();
    }
    return produto;
}

partial class Program
{
    static HttpClient client = new HttpClient();
}
