using System.ComponentModel.DataAnnotations;

namespace DZA.Cadastro.Application.DTO;

public class PessoaDTO
{
    private const string messageRequired = "O campo {0} deve ser informado.";
    private const string messageStringLength = "O campo {0} deve ter no maximo {1} caracteres.";
    private const string messageRange = "O campo {0} deve ter entre {1} e {2}.";

    [Key]
    public Guid Id { get; set; }

    public Guid? DepartamentoId { get; set; }
    
    [Required(AllowEmptyStrings = true, ErrorMessage = messageRequired)]
    [StringLength(60, ErrorMessage = messageStringLength)]
    public string Nome { get; set; }

    [Required(AllowEmptyStrings = true, ErrorMessage = messageRequired)]
    [StringLength(60, ErrorMessage = messageStringLength)]
    public string SobreNome { get; set; }

    [Required(AllowEmptyStrings = true, ErrorMessage = messageRequired)]
    [Range(1,120, ErrorMessage = messageRange)]
    public int Idade { get; set; }
}
