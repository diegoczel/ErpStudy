using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class LinhaProducaoRepository : CrudRepository<LinhaProducao>, ILinhaProducaoRepository
{
    public LinhaProducaoRepository(AppDbContext context) : base(context)
    {
        
    }
}
