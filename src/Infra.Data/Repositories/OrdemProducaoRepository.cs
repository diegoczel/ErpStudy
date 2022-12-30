using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class OrdemProducaoRepository : CrudRepository<OrdemProducao>, IOrdemProducaoRepository
{
    public OrdemProducaoRepository(AppDbContext context) : base(context)
    {

    }
}