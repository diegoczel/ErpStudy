namespace Domain.Models;

public class ApontamentoProducao : Entity
{
    public int Empresa { get; set; }

    public int OrdemProducaoId { get; set; }
    public OrdemProducao OrdemProducao { get; set; }

    public int RoteiroProducaoOrigemId { get; set; }
    public RoteiroProducao RoteiroProducaoOrigem { get; set; }

    public int RoteiroProducaoDestinoId { get; set; }
    public RoteiroProducao RoteiroProducaoDestino { get; set; }

    public decimal Quantidade { get; set; }
}
