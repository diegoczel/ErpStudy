namespace Application.DTOs;

public class RoteiroProducaoGetDTO
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public int LinhaProducaoId { get; set; }

    public int Sequencia { get; set; }

    public string Descricao { get; set; } = String.Empty;
}
