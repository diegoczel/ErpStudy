using Application.DTOs;

namespace Application.Interfaces
{
    public interface IRecursosProducaoService
    {
        Task<RecursosProducaoGetDTO> Create(RecursosProducaoPostDTO recurso);

        Task<RecursosProducaoGetDTO>? GetById(int id);
    }
}
