using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class RecursosProducaoService : IRecursosProducaoService
{
    private readonly IRecursosProducaoRepository _repository;
	private readonly IMapper _mapper;

	public RecursosProducaoService(IRecursosProducaoRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<RecursosProducaoGetDTO> Create(RecursosProducaoPostDTO recurso)
	{
		var recursoEntity = _mapper.Map<RecursosProducao>(recurso);
		return _mapper.Map<RecursosProducaoGetDTO>(await _repository.CreateAsync(recursoEntity));
	}

	public async Task<RecursosProducaoGetDTO>? GetById(int id)
	{
		var recurso = await _repository.GetByIdAsync(id);

		return (recurso is null) ? null : _mapper.Map<RecursosProducaoGetDTO>(recurso);
	}
}
