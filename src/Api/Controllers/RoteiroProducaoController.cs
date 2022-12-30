using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RoteiroProducaoController : ControllerBase
{
    private readonly IRoteiroProducaoService _roteiroService;

	public RoteiroProducaoController(IRoteiroProducaoService roteiroService)
	{
        _roteiroService = roteiroService;
	}

	[HttpPost]
	[ProducesResponseType(StatusCodes.Status201Created)]
	public async Task<IActionResult> Create([FromBody] RoteiroProducaoPostDTO roteiro)
	{
		if(!ModelState.IsValid)
		{
			return BadRequest();
		}

		var roteiroBanco = await _roteiroService.Create(roteiro);

		return CreatedAtAction(nameof(GetById), new {id = roteiroBanco.Id}, roteiroBanco);
	}

	[HttpGet("{id:int}")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetById(int id)
	{
		var roteiro = await _roteiroService.GetById(id);

		if (roteiro is null) return NotFound();

		return Ok(roteiro);
	}
}
