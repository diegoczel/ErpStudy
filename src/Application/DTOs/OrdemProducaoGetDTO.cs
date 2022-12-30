using Domain.Models;

namespace Application.DTOs;

public class OrdemProducaoGetDTO
{
    public int Id { get; set; }

    public int Empresa { get; set; }

    public string Numero { get; set; } = string.Empty;

    public int ProdutoId { get; set; }

    public int LinhaProducaoId { get; set; }

    public EOrdemProducaoStatus Status { get; set; }

    public double QuantidadeAbertura { get; set; }

    public double QuantidadeFinalizada { get; set; }

}