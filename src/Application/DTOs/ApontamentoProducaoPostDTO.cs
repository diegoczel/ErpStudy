namespace Application.DTOs;

public class ApontamentoProducaoPostDTO
{
    public int Empresa { get; set; }

    public int OrdemProducaoId { get; set; }

    public int RoteiroProducaoOrigemId { get; set; }

    public int RoteiroProducaoDestinoId { get; set; }

    public decimal Quantidade { get; set; }
}
