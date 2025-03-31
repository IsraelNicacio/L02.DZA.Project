using DZA.Cadastro.Application.DTO;

namespace DZA.Cadastro.Application.Services;

public interface IPessoaService
{
    Task<IEnumerable<PessoaDTO>> ObterPessoas();
    Task<IEnumerable<PessoaDTO>> ObterPessoasPorIdDepartamento(Guid idDepartamento);
    Task<PessoaDTO> ObterPessoaPorId(Guid id);
    void AdicionarPessoa(PessoaDTO pessoa);
    void AtualizarPessoa(PessoaDTO pessoa);
}
