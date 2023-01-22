using Api.GraphQL.Client.Graphql.Consumer;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.GraphQL.Client.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoConsumer _consumer;

    public ProdutosController(ProdutoConsumer consumer)
    {
        _consumer = consumer;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var produtos = await _consumer.GetAllProdutos();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var produto = await _consumer.GetById(id);
        return Ok(produto);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Produto pro)
    {
        await _consumer.CreateProduto(pro);
        return CreatedAtAction(nameof(GetById), new { id = pro.Id }, pro);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Produto pro)
    {
        await _consumer.UpdateProduto(pro);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        return (await _consumer.DeleteProduto(id)) ? NoContent() : NotFound();
    }
}
