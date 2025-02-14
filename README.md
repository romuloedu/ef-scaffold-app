# EF Scaffold App

## Autor
**Nome:** Romulo Eduardo 
**GitHub:** [github.com/romuloedu](https://github.com/romuloedu)

## Data de Criação
14 de fevereiro de 2025

## Descrição
O **EF Scaffold App** é uma aplicação Windows Forms em C# que facilita a criação de scaffoldings de banco de dados usando Entity Framework Core. A aplicação permite a execução do comando `dotnet ef dbcontext scaffold` de forma intuitiva através de uma interface gráfica amigável.

## Funcionalidades
- **Gerar Scaffold:** Execute o comando `dotnet ef dbcontext scaffold` com parâmetros personalizados.
- **Verificação do SDK .NET:** Verifica se o SDK do .NET está instalado e disponível.
- **Seleção de Arquivos e Pastas:** Selecione arquivos `.cs` e `.csproj`/`.sln` e pastas diretamente através da interface.
- **Saída do Comando:** Exibe a saída do comando `dotnet ef` em uma área de texto.

## Requisitos
- .NET Core 8.0
- Entity Framework Core
- SDK do .NET instalado

## Instalação
1. Clone o repositório:
   ```bash
   git clone https://github.com/romuloedu/ef-scaffold-app.git
   ```
2. Abra o projeto no Visual Studio.
3. Restaure os pacotes NuGet:
   ```bash
   dotnet restore
   ```
4. Compile e execute a aplicação.

## Como Usar
1. Abra a aplicação.
2. Preencha os campos necessários:
   - Nome da String de Conexão
   - Arquivo de Contexto (.cs)
   - Tabelas (Separadas por ponto-e-vírgula)
   - Pasta de Saída das Entidades
   - Arquivo do Projeto (.csproj)
3. Clique no botão "Gerar Scaffold".
4. A saída do comando será exibida na área de texto abaixo do botão.

## Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests. Veja nossas [diretrizes de contribuição](CONTRIBUTING.md) para mais detalhes.

## Licença
Este projeto está licenciado sob a Licença MIT - veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## Contato
Se você tiver alguma dúvida ou sugestão, entre em contato:
- GitHub: [github.com/romuloedu](https://github.com/romuloedu)

## Agradecimentos
Agradecimentos especiais a todos os contribuidores deste projeto!

---

Feito com ❤️ por Romulo Eduardo
```
