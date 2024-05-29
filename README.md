# Project Info

Language: C#
Framework: .NET
Type: RestAPI
Database: Postgres
OS: Linux


# Database - Migration 

-  Add a migration: `dotnet ef migrations add <name>`
-  Remove latest migration: `dotnet ef migrations remove`
-  Update database: `dotnet ef database update -v`
-  If you have already updated database, but regret the last migration. You could do: `dotnet ef database update <nameOfMigration> -v`. Then remove the last migration locally: `dotnet ef migrations remove`  
