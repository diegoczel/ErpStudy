using Application.DTOs;

namespace Application.Interfaces
{
    public interface IApontamentoProducaoService
    {
        Task<ApontamentoProducaoGetDTO> Create(ApontamentoProducaoPostDTO apontamento);

        Task<ApontamentoProducaoGetDTO>? GetById(int id);
    }
}
