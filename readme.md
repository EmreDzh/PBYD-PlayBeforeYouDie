# Welcome to Play Before You Die!

Play Before You Die is an ASP.NET MVC application that stores games with all their details, data, information and modifications to make the selected games understandable! 
 > The idea for this project came from me, because as a gamer, before you play a game, you have to research if it's playable on your platform and search many websites for a specific mod that could improve the functionality and graphics of the game by a lot. This makes the process much easier and puts everything into 1 application.

## Product Documentation

-Summary of the application



## Application setup

Step 1
- Clone the repo and open the PBYD - PlayBeforeYoyDie.sln project file in the 'PBYD - PlayBeforeYouDie' folder

Step 2
Initialize user secrets for the project
- The Keys needed for the project to work properly are:
- "DbUser"
- "DbPassword"
- "DbConfiguration:ConnectionString"

Step 3
- Should be ready to use!

## Technical Documentation

- The application uses SqlServer DbContext + Identity for the user control.
- The application uses Repository and In Memory DB pattern for getting data from the database.



## Tech Tools:

API

- ASP.Net Core 6.0
- EntityFramework Core 6.0.1
- Z.EntityFramework.Extensions.EFCore 6.16.1
- LinqKit 1.2.2
- Microsoft.AspNetCore.Identity 6.0.1
- Microsoft.AspNetCore.Authentication.JwtBearer 6.0.9

Front End
- Razor Pages 
- Bootstrap 5.1

Database
- MSSQL Server

Tests
-NUnit 3.13.3
-NUnit3TestAdapter 4.3.1
-Moq 4.18.2
-Microsoft.EntityFrameworkCore.InMemory 6.0.11

Git tools
- GitHub
- GitHub Desktop/Tortoise Git