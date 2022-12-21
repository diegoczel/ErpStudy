using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services;

public class OrdemProducaoService : IOrdemProducaoService
{
    private readonly IOrdemProducaoRepository _repository;
    private readonly IMapper _mapper;

    public OrdemProducaoService(IOrdemProducaoRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<OrdemProducao> Create(OrdemProducaoPostDTO ordem)
    {
        var ordemEntity = _mapper.Map<OrdemProducao>(ordem);
        return await _repository.CreateAsync(ordemEntity);
    }

    public async Task<OrdemProducaoGetDTO>? GetById(int id)
    {
        var ordem = await _repository.GetByIdAsync(id);
        return (ordem is null) ? null : _mapper.Map<OrdemProducaoGetDTO>(ordem);
    }
}
