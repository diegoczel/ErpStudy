namespace Domain.Models;

public class LinhaProducao : Entity
{
    public int Empresa { get; set; }
    public string Descricao { get; set; } = String.Empty;
}
