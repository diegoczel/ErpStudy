using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class RoteiroProducaoService : IRoteiroProducaoService
{
    private readonly IRoteiroProducaoRepository _repository;
	private readonly IMapper _mapper;

	public RoteiroProducaoService(IRoteiroProducaoRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<RoteiroProducaoGetDTO> Create(RoteiroProducaoPostDTO roteiro)
	{
		var roteiroEntity = _mapper.Map<RoteiroProducao>(roteiro);
		return _mapper.Map<RoteiroProducaoGetDTO>(await _repository.CreateAsync(roteiroEntity));
	}

	public async Task<RoteiroProducaoGetDTO>? GetById(int id)
	{
		var roteiro = await _repository.GetByIdAsync(id);

		return (roteiro is null) ? null : _mapper.Map<RoteiroProducaoGetDTO>(roteiro);
	}
}
