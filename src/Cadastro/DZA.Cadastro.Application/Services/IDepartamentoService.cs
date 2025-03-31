using DZA.Cadastro.Application.DTO;

namespace DZA.Cadastro.Application.Services;

public interface IDepartamentoService
{
    Task<IEnumerable<DepartamentoDTO>> ObterDepartamentos();
    Task<DepartamentoDTO> ObterDepartamentoPorId(Guid id);
    void AdicionarDepartamento(DepartamentoDTO departamento);
    void AtualizarDepartamento(DepartamentoDTO departamento);
}
