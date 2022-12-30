using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class ConsumoProducaoService : IConsumoProducaoService
{ 
	private readonly IConsumoProducaoRepository _repository;
	private readonly IMapper _mapper;

	public ConsumoProducaoService(IConsumoProducaoRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<ConsumoProducaoGetDTO> Create(ConsumoProducaoPostDTO consumo)
	{
		var consumoEntity = _mapper.Map<ConsumoProducao>(consumo);
		return _mapper.Map<ConsumoProducaoGetDTO>(await _repository.CreateAsync(consumoEntity));
	}

	public async Task<ConsumoProducaoGetDTO>? GetById(int id)
	{
		var consumo = await _repository.GetByIdAsync(id);

		return (consumo is null) ? null : _mapper.Map<ConsumoProducaoGetDTO>(consumo);
	}
}
