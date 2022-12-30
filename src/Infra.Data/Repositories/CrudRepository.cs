using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Repositories;

public class CrudRepository<T> : ICrudRepository<T> where T : Entity
{
    private readonly AppDbContext _context;

    public CrudRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<T> CreateAsync(T entity)
    {
        _context.Set<T>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<T>? GetByIdAsync(int id)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(t => t.Id == id);
    }
}
