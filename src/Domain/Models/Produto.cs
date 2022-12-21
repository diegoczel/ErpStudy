namespace Domain.Models;

public class Produto : Entity
{
    public string Nome { get; set; } = String.Empty;

    public string Complemento { get; set; } = String.Empty;

    public EProdutoTipo ProdutoTipo { get; set; }
}
