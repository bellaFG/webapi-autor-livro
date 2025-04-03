# 📚 API de Autores e Livros

API REST simples desenvolvida com .NET 8 e Entity Framework Core para gerenciar autores e livros. Projeto de estudo.

## 🚀 Tecnologias Utilizadas

- .NET 8
- Entity Framework Core
- ASP.NET Core Web API
- SQLite (ou outro banco de dados relacional, configurável via EF Core)

## 📂 Estrutura do Projeto

```
/WebApi8
│── Controllers
│   ├── AutorController.cs
│   ├── LivroController.cs
│── Data
│   ├── AppDbContext.cs
│── Dto
│   ├── Autor
│   │   ├── AutorCriacaoDto.cs
│   │   ├── AutorEdicaoDto.cs
│   ├── Livro
│       ├── LivroCriacaoDto.cs
│       ├── LivroEdicaoDto.cs
│── Models
│   ├── AutorModel.cs
│   ├── LivroModel.cs
│   ├── Response.cs
│── Services
│   ├── AutorService.cs
│   ├── IAutorService.cs
│   ├── LivroService.cs
│   ├── ILivroService.cs
│── Program.cs
│── README.md
```

## 🔧 Como Executar o Projeto

### 1️⃣ Pré-requisitos
- [.NET 8 SDK](https://dotnet.microsoft.com/)
- [SQLite](https://www.sqlite.org/) ou outro banco relacional configurado no `AppDbContext`

### 2️⃣ Configuração do Banco de Dados
1. Acesse o diretório do projeto:
   ```sh
   cd WebApi8
   ```
2. Aplicar as migrations:
   ```sh
   dotnet ef database update
   ```

### 3️⃣ Executando a API
```sh
dotnet run
```
A API estará disponível em `https://localhost:7221`.

## 🛠 Endpoints Disponíveis

### 📌 Autores
- **Criar Autor:** `POST /api/Autor/CriarAutor`
- **Buscar Autor por ID:** `GET /api/Autor/{id}`
- **Buscar Autor por ID do Livro:** `GET /api/Autor/BuscarPorLivro/{idLivro}`
- **Listar Autores:** `GET /api/Autor`
- **Editar Autor:** `PUT /api/Autor/{id}`
- **Excluir Autor:** `DELETE /api/Autor/{id}`

### 📌 Livros
- **Criar Livro:** `POST /api/Livro/CriarLivro`
- **Buscar Livro por ID:** `GET /api/Livro/{id}`
- **Listar Livros:** `GET /api/Livro`
- **Editar Livro:** `PUT /api/Livro/{id}`
- **Excluir Livro:** `DELETE /api/Livro/{id}`

## 📝 Exemplo de Requisição

### Criando um Autor (POST `/api/Autor/CriarAutor`)
```json
{
  "nome": "Machado",
  "sobrenome": "de Assis"
}
```

### Criando um Livro (POST `/api/Livro/CriarLivro`)
```json
{
  "titulo": "Dom Casmurro",
  "autorId": 1
}
```

## 📜 Licença

Este projeto é apenas para fins de estudo e aprendizado. Sinta-se livre para modificá-lo e aprimorá-lo!

---

🚀 Desenvolvido como projeto de estudo com .NET 8 e Entity Framework Core.

