using Domain.Models;

namespace Application.DTOs;

public class ProdutoGetDTO
{
    public int Id { get; set; }

    public string Nome { get; set; } = String.Empty;

    public string Complemento { get; set; } = String.Empty;

    public EProdutoTipo ProdutoTipo { get; set; }
}
