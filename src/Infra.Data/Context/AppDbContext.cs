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
}