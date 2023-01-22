using Domain.Models;
using HotChocolate;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Api.GraphQL.GraphQL.Mutation;

public class MutationType
{
    public async Task<Produto> SaveProdutoAsync([Service] AppDbContext context, Produto produto)
    {
        context.Produtos.Add(produto);
        await context.SaveChangesAsync();
        return produto;
    }

    public async Task<Produto> UpdateProdutoAsync([Service] AppDbContext context, Produto produto)
    {
        context.Produtos.Update(produto);
        await context.SaveChangesAsync();
        return produto;
    }

    public async Task<bool> DeleteProdutoAsync([Service] AppDbContext context, int id)
    {
        var produto = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

        if (produto == null)
            return false;

        context.Produtos.Remove(produto);
        await context.SaveChangesAsync();
        return true;
    }
}
