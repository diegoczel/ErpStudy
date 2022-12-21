namespace Domain.Models;

public class OrdemProducao : Entity
{
    public int Empresa { get; set; }

    public string Numero { get; set; } = string.Empty;

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }

    public EOrdemProducaoStatus Status { get; set; }

    public double QuantidadeAbertura { get; set; }

    public double QuantidadeFinalizada { get; set; }
}