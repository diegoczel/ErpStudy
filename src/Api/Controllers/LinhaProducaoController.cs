using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class LinhaProducaoController : ControllerBase
{
    private readonly ILinhaProducaoService _linhaService;

	public LinhaProducaoController(ILinhaProducaoService linhaService)
	{
        _linhaService = linhaService;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] LinhaProducaoPostDTO linha)
	{
		if(!ModelState.IsValid)
		{
			return BadRequest();
		}

		var linhaBanco = await _linhaService.Create(linha);

		return CreatedAtAction(nameof(GetById), new {id = linhaBanco.Id}, linhaBanco);
	}

	[HttpGet("{id:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetById(int id)
	{
		var linha = await _linhaService.GetById(id);

		if (linha is null) return NotFound();

		return Ok(linha);
	}
}
