using Domain.Models;
using HotChocolate;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.GraphQL.GraphQL.Query;

public class QueryType
{
    // is an Resolver. Return response to the user
    public async Task<IEnumerable<Produto>> AllProdutosAsync([Service] AppDbContext context)
    {
        // TODO ? change to Repository or Service
        return await context.Produtos.ToListAsync();
    }

    public async Task<Produto> ProdutoAsync([Service] AppDbContext context, int id)
    {
        return await context.Produtos.FirstOrDefaultAsync(p => p.Id == id);
    }
}
