using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class ProdutoService : IProdutoService
{
    private readonly IProdutoRepository _repository;
	private readonly IMapper _mapper;

	public ProdutoService(IProdutoRepository repository, IMapper mapper)
	{
		_repository = repository;
		_mapper = mapper;
	}

	public async Task<ProdutoGetDTO> Create(ProdutoPostDTO produto)
	{
		var produtoEntity = _mapper.Map<Produto>(produto);
		return _mapper.Map<ProdutoGetDTO>(await _repository.CreateAsync(produtoEntity));
	}

	public async Task<ProdutoGetDTO>? GetById(int id)
	{
		var produto = await _repository.GetByIdAsync(id);

		return (produto is null) ? null : _mapper.Map<ProdutoGetDTO>(produto);
	}
}
