using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class RecursosProducaoRepository : CrudRepository<RecursosProducao>, IRecursosProducaoRepository
{
	public RecursosProducaoRepository(AppDbContext context) : base(context)
	{

	}
}
