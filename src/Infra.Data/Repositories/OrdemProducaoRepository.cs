using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;

namespace Infra.Data.Repositories;

public class OrdemProducaoRepository : IOrdemProducaoRepository
{
    private readonly AppDbContext _context;

    public OrdemProducaoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<OrdemProducao> CreateAsync(OrdemProducao ordem)
    {
        _context.OrdemProducao.Add(ordem);
        await _context.SaveChangesAsync();
        return ordem;
    }

    public async Task<OrdemProducao>? GetByIdAsync(int id)
    {
        return _context.OrdemProducao.FirstOrDefault(o => o.Id == id);
    }
}