using DZA.Cadastro.Domain.Repositories;
using DZA.Cadastro.Infrastructure.Data.Context;

namespace DZA.Cadastro.Infrastructure.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly CadastroContext _cadastroContext;
    private IPessoaRepository _pessoa;

    public UnitOfWork(CadastroContext cadastroContext) 
        => _cadastroContext = cadastroContext;

    public IPessoaRepository Pessoa 
        => _pessoa ?? (_pessoa = new PessoaRepository(_cadastroContext));

    public bool Commit() 
        => _cadastroContext.SaveChanges() > 0;

    public void Dispose() 
        => _cadastroContext.Dispose();
}
