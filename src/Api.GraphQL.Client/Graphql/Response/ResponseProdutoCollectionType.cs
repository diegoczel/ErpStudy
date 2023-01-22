using Domain.Models;

namespace Api.GraphQL.Client.Graphql.Response;

public class ResponseProdutoCollectionType
{
    public IEnumerable<Produto> Produtos { get; set; }
}
