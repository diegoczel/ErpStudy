using Domain.Models;

namespace Domain.Interfaces;

public interface IProdutoRepository
{
    Task<Produto> CreateAsync(Produto produto);

    Task<Produto>? GetByIdAsync(int id);

    Task<IEnumerable<Produto>> GetAllAsync();
}
