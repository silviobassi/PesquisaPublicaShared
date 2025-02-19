# Contratos Para integração entre Serviços

## Descrição do Projeto

- `Authors`: Silvio Bassi
- `Description`: Contratos para integrações de mensagens entre serviços
- `RepositoryUrl`: [GitHub Repository](https://github.com/silviobassi?tab=repositories)

## Funcionalidades

- Definição de eventos e contratos compartilhados.
- Suporte a .NET 9.0.

## Workflow de CI/CD

O workflow de CI/CD (`.github/workflows/dotnet.yml`) está configurado para:

- Gerar uma nova versão do pacote.
- Empacotar e publicar o pacote em [Github Packages](https://github.com/silviobassi/PesquisaPublicaShared/pkgs/nuget/PesquisaPublica.Shared).

## Publicação e Instalação

O pacote é privado, está disponível
em [Github Packages](https://github.com/silviobassi/PesquisaPublicaShared/pkgs/nuget/PesquisaPublica.Shared) e pode ser
instalado via NuGet Package Manager Console:

```shell
dotnet add package PesquisaPublica.Shared
```

## Exemplo de Uso

```csharp
using PesquisaPublica.Shared.Contracts.Events;

var evento = new PesquisaRespondidaEvent
{
    OccurredOn = DateTime.Now,
    PesquisaId = 12345,
    NomeRespondente = "João Silva",
    EmailRespondente = "joao.silva@example.com",
    IdadeRespondente = 30,
    RespostasIds = [1, 2, 3]
};
