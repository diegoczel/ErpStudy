using Domain.Models;

namespace Domain.Interfaces;

public interface IOrdemProducaoRepository : ICrudRepository<OrdemProducao>
{
    /*
    Task<OrdemProducao> CreateAsync(OrdemProducao ordem);

    Task<OrdemProducao>? GetByIdAsync(int id);
    */
}