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

		CreateMap<Produto, ProdutoPostDTO>().ReverseMap();
		CreateMap<Produto, ProdutoGetDTO>().ReverseMap();

        CreateMap<LinhaProducao, LinhaProducaoPostDTO>().ReverseMap();
        CreateMap<LinhaProducao, LinhaProducaoGetDTO>().ReverseMap();

        CreateMap<RoteiroProducao, RoteiroProducaoPostDTO>().ReverseMap();
        CreateMap<RoteiroProducao, RoteiroProducaoGetDTO>().ReverseMap();

        CreateMap<RecursosProducao, RecursosProducaoPostDTO>().ReverseMap();
        CreateMap<RecursosProducao, RecursosProducaoGetDTO>().ReverseMap();

        CreateMap<ApontamentoProducao, ApontamentoProducaoPostDTO>().ReverseMap();
        CreateMap<ApontamentoProducao, ApontamentoProducaoGetDTO>().ReverseMap();

        CreateMap<ConsumoProducao, ConsumoProducaoPostDTO>().ReverseMap();
        CreateMap<ConsumoProducao, ConsumoProducaoGetDTO>().ReverseMap();
    }
}
