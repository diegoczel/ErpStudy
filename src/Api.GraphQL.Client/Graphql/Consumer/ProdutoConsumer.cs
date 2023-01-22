using Api.GraphQL.Client.Graphql.Response;
using Domain.Models;
using GraphQL;
using GraphQL.Client.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Api.GraphQL.Client.Graphql.Consumer;

public class ProdutoConsumer
{
    private readonly IGraphQLClient _client;

	public ProdutoConsumer(IGraphQLClient client)
	{
		_client = client;
	}

	public async Task<IEnumerable<Produto>> GetAllProdutos()
	{
		var query = new GraphQLRequest {
			Query = @"query {
	allProdutos {
		id
		
	}
}"
		};

        var response = await _client.SendQueryAsync<ResponseProdutoCollectionType>(query);
        return response.Data.Produtos;
	}

	public async Task<Produto> GetById(int id)
	{
        var query = new GraphQLRequest
        {
            Query = @$"query {{
				produto(id: {id}) {{
					id
					nome
				}}
			}}"
        };

        var response = await _client.SendQueryAsync<ProdutoGraphqlResponse>(query);
		return response.Data.Produto;
	}

	public async Task<Produto> CreateProduto(Produto produtoRequest)
	{
        var query = new GraphQLRequest
        {
            Query = @"mutation($newProduto: ProdutoInput!) {
				saveProduto(produto: $newProduto) {
					id
				}
			}"
            ,Variables = new { newProduto = produtoRequest }
        };

        var response = await _client.SendMutationAsync<ProdutoGraphqlResponse>(query);
        return response.Data.Produto;
    }

    public async Task<Produto> UpdateProduto(Produto produtoRequest)
    {
        var query = new GraphQLRequest
        {
            Query = @"mutation($newProduto: ProdutoInput!) {
				updateProduto(produto: $newProduto) {
					id,
					nome,
					complemento,
					produtoTipo
				}
			}"
            ,
            Variables = new { newProduto = produtoRequest }
        };

        var response = await _client.SendMutationAsync<ProdutoGraphqlResponse>(query);
        return response.Data.Produto;
    }

    public async Task<bool> DeleteProduto(int id)
    {
        var query = new GraphQLRequest
        {
            Query = @"mutation($proId: Int!) {
				deleteProduto(id: $proId) 
			}"
            ,
            Variables = new { proId = id }
        };

        var response = await _client.SendMutationAsync<ProdutoGraphqlResponse>(query);
        return (response is null) ? false : true;
    }
}
