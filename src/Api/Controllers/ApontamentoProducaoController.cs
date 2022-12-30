using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ApontamentoProducaoController : ControllerBase
{
    private readonly IApontamentoProducaoService _apontamentoService;

	public ApontamentoProducaoController(IApontamentoProducaoService apontamentoService)
	{
        _apontamentoService = apontamentoService;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] ApontamentoProducaoPostDTO apontamento)
	{
		if(!ModelState.IsValid)
		{
			return BadRequest();
		}

		var apontamentoBanco = await _apontamentoService.Create(apontamento);

		return CreatedAtAction(nameof(GetById), new {id = apontamentoBanco.Id}, apontamentoBanco);
	}

	[HttpGet("{id:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetById(int id)
	{
		var apontamento = await _apontamentoService.GetById(id);

		if (apontamento is null) return NotFound();

		return Ok(apontamento);
	}
}
