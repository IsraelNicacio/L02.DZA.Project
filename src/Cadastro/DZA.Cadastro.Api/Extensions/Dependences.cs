using DZA.Cadastro.Application.AutoMapper;
using DZA.Cadastro.Application.Services;
using DZA.Cadastro.Domain.Repositories;
using DZA.Cadastro.Infrastructure.Data.Repositories;

namespace DZA.Cadastro.Api.Extensions;

public static class Dependences
{
    public static void AddDependences(this IServiceCollection services)
    {
        services.AddCorsServices();

        services.AddAutoMapper(typeof(DomainDTOMappingProfile));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        //services.AddScoped<IPessoaRepository, PessoaRepository>();
        services.AddScoped<IPessoaService, PessoaService>();
        services.AddScoped<IDepartamentoService, DepartamentoService>();
    }
}
