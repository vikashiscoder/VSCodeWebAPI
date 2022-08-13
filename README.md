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


DOCKER
-----------
Install docker desktop. Open the same.
1) Open Command Palette (Ctrl+Shift+P) and use Docker: Add Docker Files to Workspace... command
   Select 80 as port number. Now 80 is the internal port in the container
2) Open Command Palette (Ctrl+Shift+P) and issue Docker Images: Build Image... command.
3) docker run -p 2001:80 imagename
   docker run -p 2001:80 vscodewebapi/latest
   2001:80--> is the mapping of 80 internal port to 2001 port
4) Access site ... http://localhost:2001/api/country

Note: Debug container app with visual studio
https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2022


Create image in Azure Container Registry
------------------------------------------
1) Open Command Palette (Ctrl+Shift+P) and use Azure Container Registry : Create Registry
2) Open Command Palette (Ctrl+Shift+P) and use Azure Container Registry : Build Image in Azure
Now you can see the image in NewRegistry--> Repositories


Notes:
Below is the command to scaffold context and models in DB first approach
dotnet ef dbcontext scaffold "Server=DESKTOP-NGF7CC4\SQLEXPRESS;Database=Learn_DB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.InMemory --output-dir Models

