# Task & Team Management API

A backend API built with **.NET 9**, **Entity Framework Core**, and **ASP.NET Core Identity** for managing projects, tasks, teams, and users.  
This project follows a **clean architecture** approach using the **The Standard Book** .

---

## 🚀 Features
- User authentication & authorization with ASP.NET Core Identity
- CRUD operations for:
  - Projects
  - Tasks (TodoTasks)
  - Teams
- Assign users to tasks and teams
- Track task status (completed / not completed)
- SQL Server database integration
- Organized architecture:
  - **Brokers** (data access with StorageBroker)
  - **Models** (entities mapped to DB)
  - **Services** (business logic)
  - **Controllers** (API endpoints)

---

## 🗂️ Project Structure
```
/Brokers
   /Storages
/Models
/Services
/Controllers
```

---

## 🛠️ Technologies
- [.NET 9](https://dotnet.microsoft.com/)
- [ASP.NET Core Web API](https://learn.microsoft.com/en-us/aspnet/core/web-api)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [ASP.NET Core Identity](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity)
- SQL Server

---

## ⚙️ Setup

### Prerequisites
- .NET 9 SDK
- SQL Server (local or containerized)
- Git

### Installation
```bash
# Clone the repository
git clone https://github.com/Baselyosry/TaskManagementAPI.git
cd TaskTeamManagementAPI

# Restore dependencies
dotnet restore
```

### Database
Update the connection string in `appsettings.json`, then run:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 📌 API Endpoints (examples)
### Authentication
- `POST /api/auth/register` – Register new user
- `POST /api/auth/login` – Authenticate user

### Projects
- `GET /api/projects` – Get all projects
- `POST /api/projects` – Create project
- `PUT /api/projects/{id}` – Update project
- `DELETE /api/projects/{id}` – Delete project

### Tasks
- `GET /api/tasks` – Get all tasks
- `POST /api/tasks` – Create task
- `PUT /api/tasks/{id}` – Update task
- `DELETE /api/tasks/{id}` – Delete task

---

## 👤 Author
- **Basel Yosry**  
- [LinkedIn](https://www.linkedin.com/in/basel-yosry-27b464276)  
- [Email](officialbaselyosry@gmail.com)
