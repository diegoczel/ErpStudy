namespace Application.DTOs;

public class ConsumoProducaoGetDTO
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public int OrdemProducaoId { get; set; }

    public int ApontamentoProducaoId { get; set; }

    public int ProdutoId { get; set; }

    public decimal Quantidade { get; set; }
}
