
## Create ASP.NET Core Web API project in VS 



## Add dependencies 
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools


## Connection string
```
    # appsettings.json

    "ConnectionStrings": {
        "FullStackConnectionString": "server=BENTKPAD\\SQLEXPRESS;database=FullStackDb;Trusted_Connection=true;TrustServerCertificate=True"
    }
```

## DbContext
Data/FullStackDbContext


## Use DbContext and connection string in Program.cs
```
    # Program.cs
    builder.Services.AddDbContext<FullStackDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("FullStackConnectionString")));
```

## Create DB
Open Package Manger Console

Add migration
```
    Add-Migration "Initial Migration"
```

Create Database
```
    Update-Database
```

## Create MVC Controller



## Allow CROS
```
    # Program.cs
    app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
```