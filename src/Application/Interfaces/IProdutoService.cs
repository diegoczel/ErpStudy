using Application.DTOs;

namespace Application.Interfaces
{
    public interface IProdutoService
    {
        Task<ProdutoGetDTO> Create(ProdutoPostDTO produto);

        Task<ProdutoGetDTO>? GetById(int id);
    }
}
