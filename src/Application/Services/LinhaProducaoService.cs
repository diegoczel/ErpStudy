using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class LinhaProducaoService : ILinhaProducaoService
{
    private readonly ILinhaProducaoRepository _repository;
	private readonly IMapper _mapper;

	public LinhaProducaoService(ILinhaProducaoRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<LinhaProducaoGetDTO> Create(LinhaProducaoPostDTO linha)
	{
		
		var linhaEntity = _mapper.Map<LinhaProducao>(linha);
		return _mapper.Map<LinhaProducaoGetDTO>(await _repository.CreateAsync(linhaEntity));
	}

	public async Task<LinhaProducaoGetDTO>? GetById(int id)
	{
		var linha = await _repository.GetByIdAsync(id);

		return (linha is null) ? null : _mapper.Map<LinhaProducaoGetDTO>(linha);
	}
}
