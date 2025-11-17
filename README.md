# ASP.NET Core MVC + Entity Framework Core CRUD Microproject

This microproject demonstrates how to build a **complete CRUD module** using  
**ASP.NET Core MVC** and **Entity Framework Core (Code-First Approach)**.

It includes a fully functional Student/Employee CRUD implementation using MVC, LINQ,  
and SQL Server with EF Core.

---

## 🚀 What This Project Covers

- Setting up Entity Framework Core (Code-First)
- Creating Models and DbContext
- Using SQL Server with Connection Strings
- Creating Migrations & Updating Database
- Generating CRUD Controller + Views
- Performing Create, Read, Update, Delete operations
- Understanding MVC + EF Core working together

---

## 📂 Project Structure

/Models
Student.cs (or Employee.cs)

/Data
ApplicationContext.cs

/Controllers
StudentController.cs

/Views/Student
- Index.cshtml
- Create.cshtml
- Edit.cshtml
- Delete.cshtml
- Details.cshtml

- 
---

## 🛠 Tech Stack Used

- ASP.NET Core MVC (.NET 6/7/8)
- Entity Framework Core
- SQL Server
- LINQ
- Razor Views

---

## ▶️ How to Run This Project

1. Clone the repository:
git clone <your-repo-url>

2. Update **DefaultConnection** in `appsettings.json`.

3. Run migrations:
Add-Migration InitialCreate
Update-Database

4. Run the project:

Ctrl + F5

5. Navigate to:

/Student
or
/Employee

---

## 🧠 Key Learnings

- How MVC interacts with EF Core  
- How DbContext manages database operations  
- How scaffolding accelerates CRUD development  
- How to structure a clean ASP.NET Core project  

---

## 📚 Notes

This project is part of my **.NET Microprojects Series**:

✔ Dependency Injection  
✔ MVC + EF Core CRUD  
⬜ Repository Pattern  
⬜ Middleware  
⬜ Logging  
⬜ Authentication & Authorization  
⬜ API Development  

More coming soon! 🚀

---

## 👤 Author

**Hrishikesh Kulat**  
.NET Developer | Learning & Building  
