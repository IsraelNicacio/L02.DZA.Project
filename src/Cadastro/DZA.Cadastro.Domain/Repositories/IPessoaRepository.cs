using DZA.Cadastro.Domain.Entities;
using DZA.Core.Data;

namespace DZA.Cadastro.Domain.Repositories;

public interface IPessoaRepository : IRepository<Pessoa>
{
    Task<IEnumerable<Pessoa>> ObterPessoas();
    Task<IEnumerable<Pessoa>> ObterPessoasPorIdDepartamento(Guid idDepartamento);
    Task<Pessoa> ObterPessoaPorId(Guid id);
    void AdicionarPessoa(Pessoa pessoa);
    void AtualizarPessoa(Pessoa pessoa);

    Task<IEnumerable<Departamento>> ObterDepartamentos();
    Task<Departamento> ObterDepartamentoPorId(Guid id);
    void AdicionarDepartamento(Departamento departamento);
    void AtualizarDepartamento(Departamento departamento);
}