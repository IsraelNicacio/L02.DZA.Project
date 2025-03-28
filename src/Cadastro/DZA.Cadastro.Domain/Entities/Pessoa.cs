using DZA.Core.DomainObjects;

namespace DZA.Cadastro.Domain.Entities;

public class Pessoa : EntityCore, IAggregateRoot
{
    public Guid DepartamentoId { get; private set; }
    public string Nome { get; private set; }
    public string SobreNome { get; private set; }
    public int Idade { get; set; }
    public Departamento Departamento { get; private set; }

    public Pessoa()
    { }

    public Pessoa(string nome, string sobreNome, int idade, Guid departamentoId)
    {
        Nome = nome;
        SobreNome = sobreNome;
        Idade = idade;
        DepartamentoId = departamentoId;
        Validacoes();
    }

    public void AlterarNome(string nome)
    {
        ValidationDomain.ValidarCaracteres(nome, 60, "O campo nome deve te no maximo 60 caracteres");
        Nome = nome;
    }

    public void AlterarSobreNome(string sobreNome)
    {
        ValidationDomain.ValidarCaracteres(sobreNome, 60, "O campo nome deve te no maximo 60 caracteres");
        SobreNome = sobreNome;
    }

    public void AlterarIdade(int idade)
    {
        ValidationDomain.ValidarMinimoMaximo(idade, 0, 120, "A Idade deve ser entre 0 e 120 anos");
        Idade = idade;
    }

    public void AlterarDepartamento(Departamento departamento)
    {
        if (departamento is not null)
        {
            departamento.Validacoes();
            Departamento = departamento;
        }
    }

    public void Validacoes()
    {
        ValidationDomain.ValidarCaracteres(Nome, 60, "O campo nome deve te no maximo 60 caracteres");
        ValidationDomain.ValidarCaracteres(SobreNome, 60, "O campo nome deve te no maximo 60 caracteres");
        ValidationDomain.ValidarMinimoMaximo(Idade, 0, 120, "A Idade deve ser entre 0 e 120 anos");
    }
}