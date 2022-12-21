using Application.DTOs;
using AutoMapper;
using Domain.Models;

namespace Application.Mappings;

public class DomainToDTOMapping : Profile
{
	public DomainToDTOMapping()
	{
		CreateMap<OrdemProducao, OrdemProducaoPostDTO>().ReverseMap();
		CreateMap<OrdemProducao, OrdemProducaoGetDTO>().ReverseMap();
	}
}
