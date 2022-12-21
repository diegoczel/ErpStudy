using Domain.Models;

namespace Domain.Interfaces;

public interface IOrdemProducaoRepository
{
    Task<OrdemProducao> CreateAsync(OrdemProducao ordem);

    Task<OrdemProducao>? GetByIdAsync(int id);
}