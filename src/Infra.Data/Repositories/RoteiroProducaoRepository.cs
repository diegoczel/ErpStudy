using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class RoteiroProducaoRepository : CrudRepository<RoteiroProducao>, IRoteiroProducaoRepository
{
	public RoteiroProducaoRepository(AppDbContext context) : base(context)
	{

	}
}
