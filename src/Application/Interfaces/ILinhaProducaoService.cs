using Application.DTOs;

namespace Application.Interfaces
{
    public interface ILinhaProducaoService
    {
        Task<LinhaProducaoGetDTO> Create(LinhaProducaoPostDTO linha);

        Task<LinhaProducaoGetDTO>? GetById(int id);
    }
}
