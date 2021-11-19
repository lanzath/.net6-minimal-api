# .NET 6 Minimal API

###### Este código é um exemplo de um CRUD feito com minimal API do .NET 6 com C# 10 (LTS), como pacotes adicionais foram instalados o [Entity Framework Core SqLite](https://docs.microsoft.com/pt-br/ef/core/providers/sqlite/?tabs=dotnet-core-cli) para uso de banco de dados com o SQLite e o [Entity Framework Core Design](https://docs.microsoft.com/pt-br/ef/core/get-started/overview/install) para geração das migrations.


### Comandos
**Entity Framework (ef)**

Criando migrations:

` dotnet ef migrations add <NomeDaMigration> `

Efetuando as migrations:

` dotnet ef database update `
