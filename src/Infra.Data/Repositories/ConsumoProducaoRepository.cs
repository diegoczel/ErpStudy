using Domain.Models;
using Domain.Interfaces;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class ConsumoProducaoRepository : CrudRepository<ConsumoProducao>, IConsumoProducaoRepository
{
    public ConsumoProducaoRepository(AppDbContext context) : base(context)
    {

    }
}
