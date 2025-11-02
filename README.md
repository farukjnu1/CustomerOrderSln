📚 C# Class Library Template – Customer Order Management with Repository Pattern

A C# class library template implementing the Repository Pattern for managing customers, orders, and related entities.
This library provides a clean architecture foundation for enterprise-grade business applications, enabling data access abstraction, maintainability, and testability.

---------------------------------

📋 Overview

This project demonstrates how to implement Repository Pattern in a reusable class library:

Centralizes data access logic for multiple entities

Provides CRUD operations for Customer and Order entities

Can be used as a foundation for console apps, web apps, or APIs

Promotes separation of concerns between data, business, and presentation layers

------------------------------------

🚀 Features

🧩 Repository Pattern – Abstracts CRUD operations for all entities

👤 Customer Management – Add, update, delete, and fetch customers

🛒 Order Management – Add, update, delete, and fetch orders linked to customers

⚙️ In-Memory Data Storage – Default implementation uses in-memory collections (easily replaceable with database)

🧠 Reusable Class Library – Can be referenced by any C# project

--------------------------------------

🧩 Technologies Used
| Component          | Description                                               |
| ------------------ | --------------------------------------------------------- |
| **Language**       | C#                                                        |
| **Framework**      | .NET 6 / .NET 7 Class Library                             |
| **Design Pattern** | Repository Pattern                                        |
| **IDE**            | Visual Studio / VS Code                                   |
| **Data Storage**   | In-memory collections (List<T>) or extendable to database |

---------------------------------------

🧠 Key Concepts

Repository Pattern – Decouples data access logic from business logic

Generic Repository – Reusable across multiple entities

In-Memory Storage – Temporary, easy to extend to database

Clean Architecture – Modular design, easy to maintain and test

--------------------------------------------

🧩 Future Enhancements

🔗 Integrate with SQL Server or EF Core for persistent storage

🧪 Add unit testing for repositories and services

📦 Add Order-Customer relationship navigation with LINQ

🏢 Extend library for enterprise-level domain entities
