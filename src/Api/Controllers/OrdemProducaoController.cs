using Application.DTOs;
using Application.Interfaces;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrdemProducaoController : ControllerBase
{
	private readonly IOrdemProducaoService _ordemProducaoService;

	public OrdemProducaoController(IOrdemProducaoService ordemProducaoService)
	{
        _ordemProducaoService = ordemProducaoService;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] OrdemProducaoPostDTO ordem)
	{
		var ordemBanco = await _ordemProducaoService.Create(ordem);

		return CreatedAtAction(nameof(GetById), new { id = ordemBanco.Id }, ordemBanco);
	}

	[HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetById(int id)
	{
		var ordem = await _ordemProducaoService.GetById(id);

		if (ordem is null) return NotFound();

		return Ok(ordem);
	}
}
