using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}

	public DbSet<OrdemProducao> OrdemProducao { get; set; }

	public DbSet<Produto> Produtos { get; set; }

	public DbSet<LinhaProducao> LinhaProducao { get; set; }

	public DbSet<RoteiroProducao> RoteiroProducao { get; set; }

	public DbSet<RecursosProducao> RecursosProducao { get; set; }

	public DbSet<ApontamentoProducao> ApontamentoProducao { get; set; }

	public DbSet<ConsumoProducao> ConsumoProducao { get; set; }
}