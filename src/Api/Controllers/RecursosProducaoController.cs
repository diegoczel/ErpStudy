using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecursosProducaoController : ControllerBase
{
    private readonly IRecursosProducaoService _recursoService;

	public RecursosProducaoController(IRecursosProducaoService recursoService)
	{
        _recursoService = recursoService;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] RecursosProducaoPostDTO recurso)
	{
		if(!ModelState.IsValid)
		{
			return BadRequest();
		}

		var recursoBanco = await _recursoService.Create(recurso);

		return CreatedAtAction(nameof(GetById), new {id = recursoBanco.Id}, recursoBanco);
	}

	[HttpGet("{id:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetById(int id)
	{
		var recurso = await _recursoService.GetById(id);

		if (recurso is null) return NotFound();

		return Ok(recurso);
	}
}
