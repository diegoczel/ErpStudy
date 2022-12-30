using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Application.Services;
using Application.Validators;
using Domain.Interfaces;
using FluentValidation;
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

        #region Produto
        services.AddScoped<IProdutoRepository, ProdutoRepository>();
        services.AddScoped<IProdutoService, ProdutoService>();
        services.AddScoped<IValidator<ProdutoPostDTO>, ProdutoPostDTOValidator>();
        #endregion

        #region LinhaProducao
        services.AddScoped<ILinhaProducaoRepository, LinhaProducaoRepository>();
        services.AddScoped<ILinhaProducaoService, LinhaProducaoService>();
        #endregion

        #region RoteiroProducao
        services.AddScoped<IRoteiroProducaoRepository, RoteiroProducaoRepository>();
        services.AddScoped<IRoteiroProducaoService, RoteiroProducaoService>();
        #endregion

        #region RecursosProducao
        services.AddScoped<IRecursosProducaoRepository, RecursosProducaoRepository>();
        services.AddScoped<IRecursosProducaoService, RecursosProducaoService>();
        #endregion

        services.AddAutoMapper(typeof(DomainToDTOMapping));

        return services;
    }
}
