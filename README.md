# 📌 Task Manager API

Uma API REST desenvolvida em **C# com .NET** utilizando **arquitetura em camadas**, com o objetivo de gerenciar tarefas através de operações CRUD (Create, Read, Update e Delete).

O projeto aplica boas práticas de desenvolvimento, separando **Camada de Comunicação** e **Camada de Regras de Negócio**, garantindo melhor organização, manutenção e escalabilidade do código.


## 🚀 Tecnologias utilizadas

- C#
- .NET
- ASP.NET Core Web API
- Swagger (OpenAPI)
- Arquitetura em Camadas
- RESTful API


## 🧠 Funcionalidades

A API permite:

✔ Criar tarefas  
✔ Listar todas as tarefas  
✔ Buscar tarefa por ID  
✔ Atualizar tarefa existente  
✔ Excluir tarefa  


## 📋 Modelo de Dados

| Campo | Tipo | Obrigatório | Descrição |
|------|------|-------------|-----------|
| id | GUID | Sim | Gerado automaticamente |
| name | string | Sim | Nome da tarefa (máx. 100 caracteres) |
| description | string | Não | Descrição da tarefa (máx. 500 caracteres) |
| priority | string | Sim | high, medium ou low |
| dueDate | DateTime | Sim | Data limite da tarefa |
| status | string | Sim | pending, inProgress ou completed |


## 🔐 Validações

A API possui validações para garantir integridade dos dados:

- O **nome da tarefa é obrigatório**
- O **nome deve ter no máximo 100 caracteres**
- A **data limite não pode estar no passado**
- **Prioridade deve ser:**  
  - `high`
  - `medium`
  - `low`
- **Status deve ser:**  
  - `pending`
  - `inProgress`
  - `completed`


## 🔗 Endpoints da API

| Método | Endpoint | Descrição |
|------|------|------|
| POST | `/api/tasks` | Criar uma nova tarefa |
| GET | `/api/tasks` | Listar todas as tarefas |
| GET | `/api/tasks/{id}` | Buscar tarefa por ID |
| PUT | `/api/tasks/{id}` | Atualizar tarefa |
| DELETE | `/api/tasks/{id}` | Excluir tarefa |


## 📡 Status Code

A API retorna os seguintes status codes:

| Código | Descrição |
|------|------|
| 200 OK | Operações de leitura e atualização |
| 201 Created | Tarefa criada com sucesso |
| 204 No Content | Exclusão realizada |
| 400 Bad Request | Dados inválidos |
| 404 Not Found | Tarefa não encontrada |


## ▶️ Como executar o projeto

### 1️⃣ Clonar o repositório
```bash
git clone https://github.com/seu-usuario/task-manager-api.git
```
2️⃣ Acessar a pasta
```bash
cd task-manager-api
```
3️⃣ Restaurar dependências
```bash
dotnet restore
```
4️⃣ Executar o projeto
```bash
dotnet run
```

## 📘 Documentação da API

Após executar o projeto, acesse o Swagger para visualizar e testar os endpoints:

https://localhost:xxxx/swagger

O Swagger permite:

- Testar os endpoints

- Visualizar parâmetros

- Ver respostas da API

## 📦 Checklist de desenvolvimento

- [x] Criar projeto .NET

- [x] Configurar arquitetura em camadas

- [ ] Criar entidade Task

- [ ] Criar TaskController

- [ ] Criar endpoint para criar tarefa

- [ ] Criar endpoint para listar tarefas

- [ ] Criar endpoint para buscar tarefa por ID

- [ ] Criar endpoint para atualizar tarefa

- [ ] Criar endpoint para excluir tarefa

- [ ] Implementar validações de dados

- [ ] Implementar tratamento de erros

- [ ] Retornar status codes apropriados

- [x] Publicar código no GitHub

## 📈 Possíveis melhorias

Algumas evoluções possíveis para o projeto:

- Persistência de dados com Entity Framework + PostgreSQL ou SQL Server

- Implementação de Repository Pattern

- Uso de DTOs

- Autenticação com JWT

- Paginação na listagem de tarefas

- Testes unitários

## 💼 Objetivo do projeto

Este projeto foi desenvolvido como prática de construção de APIs REST com .NET, focando em:

- Organização de código

- Separação de responsabilidades

- Boas práticas de desenvolvimento backend

- Também faz parte do meu portfólio de desenvolvimento backend.

## 👨‍💻 Autor

Desenvolvido por Miguel Castro

Se quiser trocar ideias sobre desenvolvimento ou tecnologia, fique à vontade para se conectar comigo no LinkedIn.

