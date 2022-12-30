using Application.DTOs;

namespace Application.Interfaces
{
    public interface IRoteiroProducaoService
    {
        Task<RoteiroProducaoGetDTO> Create(RoteiroProducaoPostDTO roteiro);

        Task<RoteiroProducaoGetDTO>? GetById(int id);
    }
}
