namespace Application.DTOs;

public class LinhaProducaoGetDTO
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public string Descricao { get; set; } = String.Empty;
}
