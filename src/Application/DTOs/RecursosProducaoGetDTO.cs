namespace Application.DTOs;

public class RecursosProducaoGetDTO
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public int RoteiroProducaoId { get; set; }

    public int ProdutoId { get; set; }

    public decimal QuantidadePadrao { get; set; }
}
