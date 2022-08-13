STEPS TO CREATE A NEW .NET WEBAPI FROM VS CODE

1) dotnet new webapi -o CourseApi
   CD courseapi
2) Delete WeatherForcastController and Model
3) Create nuget.config with below content
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="NuGet Public" value="https://api.nuget.org/v3/index.json" />
  </packageSources>   
</configuration>

4) In VS Code install c#, Nuget package manager

5) dotnet tool install --global dotnet-ef --version 3.1.4

6) dotnet add package Microsoft.EntityFrameworkCore.InMemory

7) dotnet add package Microsoft.EntityFrameworkCore.Design

8) Add folder models, file Country.cs, DbContext.cs

9) Changes to program.cs

using Microsoft.EntityFrameworkCore;
using CourseApi.Models;

builder.Services.AddDbContext<AppDbContext>(x => x.UseInMemoryDatabase("InMemoryDB"));

10) dotnet run


Notes:
Below is the command to scaffold context and models in DB first approach
dotnet ef dbcontext scaffold "Server=DESKTOP-NGF7CC4\SQLEXPRESS;Database=Learn_DB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.InMemory --output-dir Models

To Deploy to Azure Container Registry
https://docs.microsoft.com/en-us/azure/container-apps/deploy-visual-studio-code

