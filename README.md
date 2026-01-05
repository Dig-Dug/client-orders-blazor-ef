# Client Orders Manager

<!-- Project Image / Architecture Diagram -->
<!-- Suggested image: a simple architecture diagram showing Blazor Server → EF Core → SQL Server -->
<!-- Example file path: docs/architecture.png -->



## Overview

Client Orders Manager is a small **CRUD application** built to practice and demonstrate a **clean Blazor Server + Entity Framework Core setup**.

The application allows managing **Clients** and their related **Orders**, focusing on:
- correct project structure
- separation of concerns
- database integration with EF Core
- server-side Blazor routing and components

This project is intentionally simple and incremental, serving as a **learning and reference project** rather than a production-ready system.

---

## Tech Stack

- **.NET 8**
- **Blazor Server**
- **Entity Framework Core**
- **SQL Server (LocalDB)**
- **C#**
- **Razor Components**
- **Git & GitHub**

---

## Project Structure

```text
ClientOrdersManager
│
├── ClientOrders.Blazor
│   ├── Components
│   │   ├── Layout
│   │   └── Routes.razor
│   ├── Pages
│   │   └── Clients
│   └── Program.cs
│
├── ClientOrders.Core
│   ├── Client.cs
│   └── Order.cs
│
├── ClientOrders.Infrastructure
│   ├── ApplicationDbContext.cs
│   └── Migrations
│
└── ClientOrders.Console
    └── Program.cs
