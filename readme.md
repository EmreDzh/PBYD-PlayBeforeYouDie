## Welcome to Play Before You Die!

Play Before You Die is a ASP.NET MVC Application that stores Games with all their details, data, information and modifications to make the selected game understandable to play! 
 > The idea of this project came from me because as a gamer: before you play any game you have to research it, see if its playable on your platform and check a lot of websites for a specific mod that might improve the game by alot. This makes the process a lot easier and sums up everything in 1 application.

## Product Documentation

-Summary of the application



## Application setup

Step 1
- Clone the repo and open the PBYD - PlayBeforeYoyDie.sln project file in the 'PBYD - PlayBeforeYouDie' folder

Step 2
- Initialize user secrets for the project
- The Keys needed for the project to work properly are:
> "DbUser"
> "DbPassword"
> "DbConfiguration:ConnectionString"

Step 3
- Should be ready to use!

## Technical Documentation

- The application uses SqlServer DbContext + Identity for the user control.
- The application uses Repository pattern for getting data from the database.



## Tech Stack:

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

Git tools
- GitHub
- GitHub Desktop/Tortoise Git