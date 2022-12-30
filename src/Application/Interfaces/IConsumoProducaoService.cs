using Application.DTOs;

namespace Application.Interfaces
{
    public interface IConsumoProducaoService
    {
        Task<ConsumoProducaoGetDTO> Create(ConsumoProducaoPostDTO consumo);

        Task<ConsumoProducaoGetDTO>? GetById(int id);
    }
}
