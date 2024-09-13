# Projeto-de-Cadastro-.NET-Razor
Projeto desenvolvido todo em C#- Back End em .NET 8.0 / Front em Razor/ MicroServices.


# InscricaoApp
Este projeto é um sistema de inscrição utilizando uma arquitetura de microserviços. O projeto é dividido em três partes:

- InscricaoApp.Api:Backend que serve como API, utilizando Entity Framework Core com SQL Server.
- InscricaoApp.Web: Frontend que consome a API.
- InscricaoApp.Domain: Biblioteca de classes que contém entidades e interfaces compartilhadas entre o frontend e o backend.

## InscricaoApp

- ├── InscricaoApp.Api       # Backend (Microserviço da API)
- ├── InscricaoApp.Web       # Frontend (Aplicação Web)
- ├── InscricaoApp.Domain    # Biblioteca compartilhada de entidades e interfaces


# 1. InscricaoApp.Domain
## Descrição:
Este projeto contém as entidades e interfaces que serão compartilhadas entre o backend e o frontend. Ele funciona como 
o "contrato" entre os microserviços.

### Estrutura:

InscricaoApp.Domain
- ├── Entities
- │   ├── Participante.cs
- │   ├── Pacote.cs
- │   └── Atividade.cs
- ├── Interfaces
- │   ├── IParticipanteRepository.cs
- │   ├── IPacoteRepository.cs
- │   └── IAtividadeRepository.cs

# 2. InscricaoApp.Api

## Descrição:
Este projeto é o backend da aplicação, responsável por fornecer a API de inscrições. 
Ele utiliza o Entity Framework Core para conectar-se a um banco de dados SQL Server e expor os endpoints necessários
para as operações de CRUD.

### Estrutura:

InscricaoApp.Api
- ├── Controllers
- │   ├── ParticipantesController.cs
- │   ├── PacotesController.cs
- │   └── AtividadesController.cs
- ├── Data
- │   └── ApplicationDbContext.cs
- ├-── Repositories
- │   ├── ParticipanteRepository.cs
- │   ├── PacoteRepository.cs
- │   └── AtividadeRepository.cs
- ├── Services
- │   ├── ParticipanteService.cs
- │   ├── PacoteService.cs
- │   └── AtividadeService.cs
- ├── Program.cs
- ├── appsettings.json
- └── launchSettings.json


# 3. InscricaoApp.Web

## Descrição:
Este projeto é o frontend da aplicação. Ele consome a API criada em InscricaoApp.Api para exibir e 
gerenciar os participantes, pacotes e atividades.

### Estrutura:

InscricaoApp.Web
- ├── Pages
- │   ├── Participantes
- │   │   ├── Create.cshtml
- │   │   ├── Create.cshtml.cs
- │   │   ├── Index.cshtml
- │   │   └── Index.cshtml.cs
- │   ├── Pacotes
- │   │   ├── Create.cshtml
- │   │   ├── Create.cshtml.cs
- │   │   ├── Index.cshtml
- │   │   └── Index.cshtml.cs
- │   ├── Atividades
- │   │   ├── Create.cshtml
- │   │   ├── Create.cshtml.cs
- │   │   ├── Index.cshtml
- │   │   └── Index.cshtml.cs
- │   ├── _ViewImports.cshtml
- │   ├── _ViewStart.cshtml
- │   └── Error.cshtml
- ├── wwwroot
- │   ├── css
- │   │   └── site.css
- │   ├── js
- │   │   └── site.js
- ├── Services
- │   └── ApiService.cs
- └── Models
    - ├── Participante.cs
    - ├── Pacote.cs
    - └── Atividade.cs


# Como Rodar o Projeto

## Pré-requisitos:
- .NET 8 SDK instalado.
- SQL Server em execução.
