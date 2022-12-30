using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ConsumoProducaoController : ControllerBase
{
    private readonly IConsumoProducaoService _consumoService;

	public ConsumoProducaoController(IConsumoProducaoService consumoService)
	{
        _consumoService = consumoService;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] ConsumoProducaoPostDTO consumo)
	{
		if(!ModelState.IsValid)
		{
			return BadRequest();
		}

		var consumoBanco = await _consumoService.Create(consumo);

		return CreatedAtAction(nameof(GetById), new {id = consumoBanco.Id}, consumoBanco);
	}

	[HttpGet("{id:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetById(int id)
	{
		var consumo = await _consumoService.GetById(id);

		if (consumo is null) return NotFound();

		return Ok(consumo);
	}
}
