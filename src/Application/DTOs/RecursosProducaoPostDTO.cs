namespace Application.DTOs;

public class RecursosProducaoPostDTO
{
    public int Empresa { get; set; }

    public int RoteiroProducaoId { get; set; }

    public int ProdutoId { get; set; }

    public decimal QuantidadePadrao { get; set; }
}
