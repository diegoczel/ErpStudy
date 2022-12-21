using Domain.Models;

namespace Application.DTOs;

public class ProdutoPostDTO
{
    public string Nome { get; set; } = String.Empty;

    public string Complemento { get; set; } = String.Empty;

    public EProdutoTipo ProdutoTipo { get; set; }
}
