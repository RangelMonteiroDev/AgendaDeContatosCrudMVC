# Agenda de Contatos CRUD

Este é um projeto simples de CRUD (Create, Read, Update, Delete) para gerenciar usuários. O sistema permite criar, listar, atualizar e excluir usuários. Ele usa **ASP.NET Core 9**, **Entity Framework Core** e **SQL Server** em um container **Docker** para o banco de dados.

## Tecnologias

- **ASP.NET Core 9**
- **Entity Framework Core**
- **SQL Server** (no Docker)
- **Bootstrap** (para o front-end)
- **VS Code** (para desenvolvimento)

## Pré-requisitos

Antes de rodar o projeto, você precisa ter o seguinte instalado:

- [Docker](https://www.docker.com/)
- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [VS Code](https://code.visualstudio.com/)

## Configuração do Docker para o SQL Server

1. **Baixar e rodar o container Docker com o SQL Server:**

   Para rodar o SQL Server em um container Docker, use o seguinte comando:

   ```bash
   docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=YourPassword' -p 1433:1433 --name sql_server_container -d mcr.microsoft.com/mssql/server:2022-latest


