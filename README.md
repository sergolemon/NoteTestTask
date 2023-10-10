# NoteTestTask
This project is a simple Blazor application on .net 6. It allows you to perform basic create, read, edit and delete (CRUD) operations.
The project uses the Postgres database and ORM system Entity Framework Core 7.
To start, you only need to configure the database connection string given in the appsettings.json file:
```json
{
  "ConnectionStrings": {
    "PostgresConnStr": "Host=localhost;Port=5432;Database=NoteDb;Username=postgres;Password=1"
  }
}

```
