namespace Application.DTOs;

public class OrdemProducaoPostDTO
{
    public int Empresa { get; set; }

    public string Numero { get; set; } = string.Empty;

    public int ProdutoId { get; set; }

    public int LinhaProducaoId { get; set; }

    public double QuantidadeAbertura { get; set; }

}