## Database first
Run command at PackageManager Console, create models and dbcontext
```
    Scaffold-DbContext "Server=(local) Database=DbEmployee, Integrated Security=true" Microsoft.EntityFrameworkCore.SqlServer -OutPutDir Models
```

Move Connection string to appsettings.json
```
    # appsettings.json

    "ConnectionStrings": {
        "MyConnectionString": "server=BENTKPAD\\SQLEXPRESS;database=MyDb;Trusted_Connection=true;TrustServerCertificate=True"
    }
```

Inject MyDbContext in Program.cs
```
    # Program.cs
    builder.Services.AddDbContext<MyDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
```


## Code first
Create Connection string
```
    # appsettings.json

    "ConnectionStrings": {
        "MyConnectionString": "server=BENTKPAD\\SQLEXPRESS;database=MyDb;Trusted_Connection=true;TrustServerCertificate=True"
    }
```
Create DbContext: Data/MyDbContext


Inject MyDbContext
```
    # Program.cs
    builder.Services.AddDbContext<MyDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));
```


Run command at  Package Manger Console

Add migration
```
    Add-Migration "Initial Migration"
```

Create Database
```
    Update-Database
```
