namespace Domain.Models;

public class ConsumoProducao : Entity
{
    public int Empresa { get; set; }

    public int OrdemProducaoId { get; set; }
    public OrdemProducao OrdemProducao { get; set; }

    public int ApontamentoProducaoId { get; set; }
    public ApontamentoProducao ApontamentoProducao { get; set; }

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }

    public decimal Quantidade { get; set; }
}
