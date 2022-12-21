using Application.DTOs;
using Application.Interfaces;
using Domain.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _produtoService;
	private readonly IValidator<ProdutoPostDTO> _validator;

	public ProdutoController(IProdutoService produtoService, IValidator<ProdutoPostDTO> validator)
	{
		_produtoService = produtoService;
		_validator = validator;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] ProdutoPostDTO produto)
	{
		var result = await _validator.ValidateAsync(produto);

		if(!result.IsValid)
		{
			return	BadRequest(result.Errors);
		}

		var produtoBanco = await _produtoService.Create(produto);

		return CreatedAtAction(nameof(GetById), new {id = produtoBanco.Id}, produtoBanco);
	}

	[HttpGet("{id:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetById(int id)
	{
		var produto = await _produtoService.GetById(id);

		if (produto is null) return NotFound();

		return Ok(produto);
	}
}
