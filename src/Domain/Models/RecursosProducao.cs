namespace Domain.Models;

public class RecursosProducao : Entity
{
    public int Empresa { get; set; }

    public int RoteiroProducaoId { get; set; }
    public RoteiroProducao RoteiroProducao { get; set; }

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }

    public decimal QuantidadePadrao { get; set; }
}
