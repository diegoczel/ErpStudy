using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class ApontamentoProducaoService : IApontamentoProducaoService
{ 
	private readonly IApontamentoProducaoRepository _repository;
	private readonly IMapper _mapper;

	public ApontamentoProducaoService(IApontamentoProducaoRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<ApontamentoProducaoGetDTO> Create(ApontamentoProducaoPostDTO apontamento)
	{
		var apontamentoEntity = _mapper.Map<ApontamentoProducao>(apontamento);
		return _mapper.Map<ApontamentoProducaoGetDTO>(await _repository.CreateAsync(apontamentoEntity));
	}

	public async Task<ApontamentoProducaoGetDTO>? GetById(int id)
	{
		var apontamento = await _repository.GetByIdAsync(id);

		return (apontamento is null) ? null : _mapper.Map<ApontamentoProducaoGetDTO>(apontamento);
	}
}
