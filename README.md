

# Q&A Web App (StackOverflow Clone) - Bluebay IT Limited

A simple StackOverflow-style Q&A web application built with ASP.NET Core MVC (.NET 8) and Entity Framework Core (SQLite).
Implements full CRUD operations for Questions and Answers with a clean service-based architecture, Razor views, and Bootstrap UI.
Developed as part of the Dot Net Developer (Intern) assignment for Bluebay IT Limited.




## Features

- Add, view, and delete questions

- Add answers to questions

- Display all questions with answer counts

- MVC pattern with service layer and dependency injection

- Code-first EF Core with SQLite

- Bootstrap UI for responsive layout

- Seeded initial questions in the database

## Tech Stack

**Frontend:** Razor Views (ASP.NET Core MVC), Bootstrap 5

**Backend:** ASP.NET Core (.NET 8), C#

**Database:** SQLite with Entity Framework Core

**Architecture:** Clean MVC + Service Layer

## Installation

Clone the project:

```bash
git clone https://github.com/TanXid/Q-A-Web-App-StackOverflow-Clone---Bluebay-IT-Limited-Internship-Task.git
cd Q-A-Web-App-StackOverflow-Clone---Bluebay-IT-Limited-Internship-Task
```


Install dependencies:

```bash
dotnet restore
```


Run migrations and create the database:
```bash
dotnet ef migrations add Initial
dotnet ef database update
```


Run the app:
```bash
dotnet run
```


    
## Screenshots

[![Home-Page.png](https://i.postimg.cc/TPbwyX3t/Home-Page.png)](https://postimg.cc/d7qvXpdC)

[![Ask-a-New-Question.png](https://i.postimg.cc/xTd1vmdd/Ask-a-New-Question.png)](https://postimg.cc/rzvTcKx6)

[![QA-1.png](https://i.postimg.cc/pLwVM1Jz/QA-1.png)](https://postimg.cc/SnGbWd5x)

[![QA-2.png](https://i.postimg.cc/fyRDv4Dx/QA-2.png)](https://postimg.cc/G8VWc5B2)
