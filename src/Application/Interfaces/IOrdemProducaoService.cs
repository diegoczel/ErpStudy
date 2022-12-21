using Application.DTOs;
using Domain.Models;

namespace Application.Interfaces;

public interface IOrdemProducaoService
{
    Task<OrdemProducaoGetDTO> Create(OrdemProducaoPostDTO ordem);
    Task<OrdemProducaoGetDTO>? GetById(int id);
}
