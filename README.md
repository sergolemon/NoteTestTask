# NoteTestTask
This project is a simple Blazor notes app on .net 6. It allows you to perform basic create, read, edit and delete (CRUD) operations.
To work with data, the project uses the Postgres database and ORM system Entity Framework Core 7.
To start, you only need to configure the database connection string given in the appsettings.json file:
```json
{
  "ConnectionStrings": {
    "PostgresConnStr": "Host=localhost;Port=5432;Database=NoteDb;Username=postgres;Password=1"
  }
}

```
There are also migrations in the project. To use migrations you need to delete the line Database.EnsureCreated(); in the file EfPostgresDbContext.cs:
```cs
public EfPostgresDbContext(DbContextOptions<EfPostgresDbContext> opts) : base(opts)
{
    //remove this before migration
    Database.EnsureCreated();
}
```
