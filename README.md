# CrudDemo (ASP.NET Core MVC + EF Core)

Demo CRUD app using EF Core (code-first) and SQL Server.

Connection string is set in `appsettings.json` to your instance `DESKTOP-OAKSJ03\\SQLEXPRESS` and database name `c`.

Quick start:

1. Open a terminal in `d:\DOTNET\cidcd\CrudDemo`.
2. Restore packages:

```bash
dotnet restore
```

3. Add and apply EF migrations (requires `dotnet-ef`):

```bash
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate -s . -p .
dotnet ef database update -s . -p .
```

4. Run the app:

```bash
dotnet run
```

Open https://localhost:5001 or the URL shown in the console. The `Products` UI is the default route.
