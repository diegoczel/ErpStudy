namespace Domain.Models;

public class Produto : Entity
{
    public Produto() { }

    public Produto(string nome, string complemento, EProdutoTipo produtoTipo) 
    {
        Nome = nome;
        Complemento = complemento;
        ProdutoTipo = produtoTipo;
    }

    public string Nome { get; set; } = String.Empty;

    public string Complemento { get; set; } = String.Empty;

    public EProdutoTipo ProdutoTipo { get; set; }

    public override string ToString()
    {
        return $"Id: {Id} | Nome: {Nome} | Complemento: {Complemento} | ProdutoTipo: {ProdutoTipo}";
    }
}
