# TodoApiWithMySQL

A simple ASP.NET(8.0) Core Web API project that manages a Todo list, connected to a MySQL database.  
Built for learning and practicing .NET 8 and Entity Framework Core.

---

## 📚 Project Structure
- ASP.NET Core 8.0 Web API
- MySQL Database
- Entity Framework Core 8

---
### NuGet Packages

The following NuGet packages are used in this project:

| Package Name                        | Requested Version                        | Resolved Version                     |
|-------------------------------------|------------------------------------------|---------------------------------------|
| **Microsoft.AspNetCore.OpenApi**    | 8.0.15                                   | 8.0.15                               |
| **Microsoft.EntityFrameworkCore.Design** | 9.0.4                              | 9.0.4                                |
| **MySql.EntityFrameworkCore**       | 5.0.0                                   | 5.0.0                                |
| **Pomelo.EntityFrameworkCore.MySql** | 9.0.0-preview.3.efcore.9.0.0            | 9.0.0-preview.3.efcore.9.0.0        |
| **Swashbuckle.AspNetCore**          | 6.6.2    

## Compatibility Note:
All the listed package versions are compatible with the .NET 8.0 framework, ensuring smooth integration into your project.

## 🚀 How to Run Locally

### 1. Clone the repository
```bash
git clone https://github.com/Mvikum/TodoApiWithMySQL.git
cd TodoApiWithMySQL
```
### 2. Setup database
- Install MySql.
- Create Database : CREATE DATABASE todoapi;
- Change appsettings.json file to Configure the Connection String : "TodoDb": "server=localhost;port=3306;database=todoapi;user=[your_user_name];password=[your_password]"

### 3. Install Dependencies
```bash
dotnet restore
```

### 4. Run Migrations.
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5. Build and Run
```bash
dotnet build
dotnet run
```
### API Testing
If you're using Visual Studio Code, you can leverage the **REST Client** extension to send HTTP requests and view the responses directly within the editor.

Alternatively, you can use **POSTMAN**, a powerful tool for more advanced API testing and management.
API are available at : ToDoApi.http in the root directory.
