using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
            );
        });

        #region OrdemProducao
        services.AddScoped<IOrdemProducaoRepository, OrdemProducaoRepository>();
        services.AddScoped<IOrdemProducaoService, OrdemProducaoService>();
        #endregion

        services.AddAutoMapper(typeof(DomainToDTOMapping));

        return services;
    }
}
