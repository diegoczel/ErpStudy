using Domain.Models;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class ApontamentoProducaoRepository : CrudRepository<ApontamentoProducao>, IApontamentoProducaoRepository
{
    public ApontamentoProducaoRepository(AppDbContext context) : base(context)
    {

    }
}