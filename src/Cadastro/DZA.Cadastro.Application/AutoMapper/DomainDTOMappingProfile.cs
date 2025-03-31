using AutoMapper;
using DZA.Cadastro.Application.DTO;
using DZA.Cadastro.Domain.Entities;

namespace DZA.Cadastro.Application.AutoMapper;

public class DomainDTOMappingProfile : Profile
{
    public DomainDTOMappingProfile()
    {
        CreateMap<Pessoa, PessoaDTO>().ReverseMap();
        CreateMap<Departamento, DepartamentoDTO>().ReverseMap();
    }
}
