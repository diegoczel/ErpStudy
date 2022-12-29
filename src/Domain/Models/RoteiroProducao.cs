namespace Domain.Models;

public class RoteiroProducao : Entity
{
    public int Empresa { get; set; }

    public int LinhaProducaoId { get; set; }
    public LinhaProducao LinhaProducao { get; set; }

    public int Sequencia { get; set; }

    public string Descricao { get; set; } = String.Empty;
}
