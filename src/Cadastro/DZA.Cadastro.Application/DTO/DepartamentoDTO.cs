using System.ComponentModel.DataAnnotations;

namespace DZA.Cadastro.Application.DTO;

public class DepartamentoDTO
{
    private const string messageRequired = "O campo {0} deve ser informado.";
    private const string messageStringLength = "O campo {0} deve ter no maximo {1} caracteres.";

    [Key]
    public Guid Id { get; set; }
    
    [Required(AllowEmptyStrings = true, ErrorMessage = messageRequired)]
    [StringLength(60, ErrorMessage = messageStringLength)]
    public string Nome { get; set; }
}