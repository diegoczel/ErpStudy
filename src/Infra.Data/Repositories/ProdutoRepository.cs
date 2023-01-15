using Domain.Interfaces;
using Domain.Models;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Infra.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> CreateAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto>? GetByIdAsync(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

    }
}
