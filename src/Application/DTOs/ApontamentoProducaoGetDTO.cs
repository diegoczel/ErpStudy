namespace Application.DTOs;

public class ApontamentoProducaoGetDTO
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public int OrdemProducaoId { get; set; }

    public int RoteiroProducaoOrigemId { get; set; }

    public int RoteiroProducaoDestinoId { get; set; }

    public decimal Quantidade { get; set; }
}
