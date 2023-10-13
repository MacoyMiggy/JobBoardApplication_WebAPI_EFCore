# JobBoardApplication_WebAPI_EFCore
This Job Board Application is created using ASP.NET Core WEB API 6.0 and Entity Framework Core 6.0 (REST API Method)
For DB Connections I created database named "JobBoardApp_WebAPI" and two tables named (dbo.Applicant and dbo.JobPositions) using Local DB SQL Server 15.0.41.33 under Visual Studio.
Download the application in your local and run it to Debug mode and it can be view using SWAGGER for its API's and SCHEMAS. (e.g. https://localhost:7264/swagger/index.html)

Packages I used under MS Visual Studio 2022: 
Bricelam.EntityFrameworkCore.Pluralizer(1.0.0), 
Microsoft.EntityFrameworkCore.SqlServer(7.0.12), 
Microsoft.EntityFrameworkCOre.Tools(7.0.12), 
Microsoft.VisualStudio.Web.CodeGeneration.Design(6.0.16), 
Swashbuckle.AspNetCore(6.5.0)

Mock Data or Seeding Data for tables under JobBoardApp_WebAPI Database. (Example Data)
1. Open command prompt and change the directory path locates into "program.cs" use, --> cd "local_directory_path" (e.g. C:\Source\JobBoarApp_WebAPI_EFCore\JobBoardApplication_WebAPI_EFCore\JobBoardApplication_WebAPI_EFCore )
2. Then type, "dotnet run seeddata" then hit Enter.
3. It will seed data for tables "dbo.Applicant" and "dbo.JobPosition".

For CI/CD process we can do it using Azure DevOps Build and Release Pipeline configuration, however I can't configured it using our paid and license DevOps tools on my current company. 
But rest assured that I can share my technical knowledge about Azure DevOps CICD Process using TDD (SpecFlow Gherkin + XUnit), SonarCloud(CleanCode) and Ranorex Automation (UAT)
