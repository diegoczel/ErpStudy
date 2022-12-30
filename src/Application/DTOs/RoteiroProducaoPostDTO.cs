namespace Application.DTOs;

public class RoteiroProducaoPostDTO
{
    public int Empresa { get; set; }

    public int LinhaProducaoId { get; set; }

    public int Sequencia { get; set; }

    public string Descricao { get; set; } = String.Empty;
}
