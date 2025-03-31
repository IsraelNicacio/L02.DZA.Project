using DZA.Cadastro.Application.DTO;
using DZA.Cadastro.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DZA.Cadastro.Api.Controllers
{
    [ApiController]
    [Route("{tenant}/[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoa;

        [HttpGet(Name = "ObterPessoas")]
        public async Task<IEnumerable<PessoaDTO>> GetPessoas()
            => await _pessoa.ObterPessoas();

        [HttpGet("ObterPessoa/{Id:Guid}")]
        public async Task<PessoaDTO> GetPessoaId(Guid id)
            => await _pessoa.ObterPessoaPorId(id);

        [HttpGet("ObterPessoasPorDepartamento/{id:Guid}")]
        public async Task<IEnumerable<PessoaDTO>> GetPessoasDepartamento(Guid idDepartamento)
            => await _pessoa.ObterPessoasPorIdDepartamento(idDepartamento);

        [HttpPost("AdicionarPessoa")]
        public void PostPessoa(PessoaDTO pessoaDto)
            => _pessoa.AdicionarPessoa(pessoaDto);
    }
}
