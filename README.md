
# Logo 1

![Logo](https://dev-to-uploads.s3.amazonaws.com/uploads/articles/th5xamgrr6se0x5ro4g6.png)

# Logo 2

<div align="center">
  <img height="200" src="./Assets/Logo_IDN_DEV_Sem_Fundo.png"  />
</div>


# Projeto Rest Api

Projeto de teste feito em DDD para efetuar Deploy em Docker


## Documentação da API

#### Retorna lista de pessoas

```http
  GET tenant/Pessoa/ObterPessoas
```

| Parâmetro   | Tipo       | Obrigatório |Descrição                           |
| :---------- | :--------- | :---------  |:---------------------------------- |
| `tenant` | `string` | **Sim** | O tenant representa o nome da base de dados |

#### Retorna uma Pessoa

```http
  GET tenant/Pessoa/ObterPessoa/{Id}
```

| Parâmetro   | Tipo       | Obrigatório |Descrição                          |
| :---------- | :--------- | :---------  |:----------------------------------|
| `id`      | `Guid` | **Sim** | O ID da Pessoa que você quer                |
| `tenant` | `string` | **Sim** | O tenant representa o nome da base de dados|

#### Retorna uma lista de pessoas usando o Id do Departamento

```http
GET tenant/Pessoa/ObterPessoasPorDepartamento/{Id}
```

| Parâmetro   | Tipo       | Obrigatório |Descrição                          |
| :---------- | :--------- | :---------  |:----------------------------------|
| `id`      | `Guid` | **Sim** | O ID do Departamento que você quer          |
| `tenant` | `string` | **Sim** | O tenant representa o nome da base de dados|

#### Adiciona uma nova pessoa

```http
POST tenant/Pessoa/AdicionarPessoa
```

| Parâmetro   | Tipo       | Obrigatório |Descrição                          |
| :---------- | :--------- | :---------  |:----------------------------------|
| `tenant` | `string` | **Sim** | O tenant representa o nome da base de dados|

#### Exemplo Request body

```json
{
  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "departamentoId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "nome": "string",
  "sobreNome": "string",
  "idade": 120
}
```

| Campo   | Tipo       | Obrigatório |Descrição                          |
| :---------- | :--------- | :---------  |:----------------------------------|
| `id`      | `Guid` | **Sim** | O ID do Departamento que você quer          |
| `departamentoId` | `Guid` | **Sim** | O ID do Departamento que você quer          |
| `nome`      |	`string`   |	**Sim**    |	Primeiro Nome da pessoa|
| `sobreNome` |	`string`   |	**Sim**    |	SobreNome da pessoa|
| `Idade`     |	`integer`   |	**Sim**    |	Idade da pessoa|


### Apendice

Se voce usa window considere instalar o WSL

[Como instalar o WSL](https://learn.microsoft.com/pt-br/windows/wsl/install)

Instale o Docker para conseguir fazer o deploy
[Instalar o Docker Desktop](https://docs-docker-com.translate.goog/desktop/setup/install/windows-install/?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt&_x_tr_pto=tc)

Após instalado e conficurado corretamente
Execute o docker-compose na raiz do projeto

## Melhorias

O CORS nesse projeto não fuinciona corretamente.
Estou procurando uma solução para permitir a comunicação do endpoint.

### Etiquetas

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)

### Stacks utilizadas

<div align="left">
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/docker/docker-original.svg" height="40" alt="docker logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" height="40" alt="csharp logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" height="40" alt="dotnetcore logo"  />
  <img width="12" />
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain.svg" height="40" alt="microsoftsqlserver logo"  />
</div>
