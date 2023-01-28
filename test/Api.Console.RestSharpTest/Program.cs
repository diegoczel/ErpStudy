using Domain.Models;
using RestSharp;


await TestGet("produto", 29);
await TestPost("produto", new Produto("Pizza", "Pizza", 0));

static async Task TestGet(string rota, int id)
{
    var request = new RestRequest($"{rota}/{id}");
    var response = await _client.GetAsync(request);
    Console.WriteLine(response.Content);
}

static async Task TestPost(string rota, Produto p)
{
    var request = new RestRequest($"{rota}", Method.Post)
        .AddJsonBody(p);

    var response = await _client.PostAsync(request);

    if(response.IsSuccessful)
        Console.WriteLine(response.Content);
}

partial class Program
{
    private static RestClient _client = new RestClient("https://localhost:7024");
}
