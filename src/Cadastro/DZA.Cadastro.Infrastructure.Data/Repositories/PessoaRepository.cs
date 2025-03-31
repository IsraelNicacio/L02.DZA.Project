using DZA.Cadastro.Domain.Entities;
using DZA.Cadastro.Domain.Repositories;
using DZA.Cadastro.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DZA.Cadastro.Infrastructure.Data.Repositories;

public class PessoaRepository : IPessoaRepository
{
    private readonly CadastroContext _cadastroContext;

    public PessoaRepository(CadastroContext cadastroContext) 
        => _cadastroContext = cadastroContext;

    public async Task<IEnumerable<Pessoa>> ObterPessoas() 
        => await _cadastroContext.Pessoas.ToListAsync();

    public async Task<Pessoa?> ObterPessoaPorId(Guid id)
        => await _cadastroContext.Pessoas.FindAsync(id);

    public async Task<IEnumerable<Pessoa>?> ObterPessoasPorIdDepartamento(Guid idDepartamento)
    {
        var dep = await _cadastroContext.Departamentos
        .Where(f => f.Id == idDepartamento)
        .FirstOrDefaultAsync();

        return dep?.Pessoas;
    }

    public void AdicionarPessoa(Pessoa pessoa) 
        => _cadastroContext.Pessoas.Add(pessoa);

    public void AtualizarPessoa(Pessoa pessoa)
        => _cadastroContext.Update(pessoa);


    public async Task<IEnumerable<Departamento>> ObterDepartamentos() 
        => await _cadastroContext.Departamentos.ToListAsync();

    public async Task<Departamento?> ObterDepartamentoPorId(Guid id)
        => await _cadastroContext.Departamentos.FindAsync(id);

    public void AdicionarDepartamento(Departamento departamento) 
        => _cadastroContext.Departamentos.Add(departamento);

    public void AtualizarDepartamento(Departamento departamento) 
        => _cadastroContext.Update(departamento);
}
