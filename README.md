Claim Management System

This is a simple ASP.NET Core MVC project that allows users to submit monthly claims. The claim details are stored in a local SQL database using Entity Framework Core.
-----------------------------------------------------------------------------------------------------
Table of Contents
1.Features
2.Technologies
3.Requirements
4.Project Setup
5.Database Setup
6.Running the Project
-----------------------------------------------------------------------------------------------------
# Features

-Submit a claim form with details like employee ID, hours worked, and hourly rate.
-Claim information is saved into the local SQL database using Entity Framework Core.
-After a successful claim submission, the user is redirected to a success page.
-----------------------------------------------------------------------------------------------------

Technologies

-).NET 8 
-)ASP.NET Core MVC
-)Entity Framework Core
-)SQL Server (LocalDB)
-)Razor Pages

-----------------------------------------------------------------------------------------------------
Requirements

-)Visual Studio 2022 
-).NET SDK
-)SQL Server or LocalDB (comes with Visual Studio)

-----------------------------------------------------------------------------------------------------

1. Clone the Repository
Clone the project from the repository:

-----------------------------------------------------------------------------------------------------

2. Open the Project in Visual Studio
Open Visual Studio.
Select Open a project or solution.
Navigate to the cloned project folder and open the .sln file.

-----------------------------------------------------------------------------------------------------

3. Install Dependencies
Once the project is open, you’ll need to restore NuGet packages. If you’re using Visual Studio, this will happen automatically when you open the project.

-----------------------------------------------------------------------------------------------------

4. Update appsettings.json
Make sure your appsettings.json has the correct connection string for your database. Here’s an example of using LocalDB, which is set up by default:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EmployeeDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}
If you are using a different SQL Server, update the DefaultConnection accordingly.
-----------------------------------------------------------------------------------------------------

Database Setup
5. Apply Migrations
Before running the project, you need to ensure that the database is set up with the appropriate tables. Entity Framework migrations will handle this.

Open the Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console).
Run the following commands to add migrations and update the database:

Add-Migration InitialMigration
Update-Database

This will create and update the database schema with the necessary tables, including the Claims table.

-----------------------------------------------------------------------------------------------------
Running the Project
-----------------------------------------------------------------------------------------------------

6. Run the Application
To run the application:

In Visual Studio, press Ctrl + F5 (or click the Run button in the toolbar).
The project will start and launch in your default browser

7. Submit a Claim
   
1.Navigate to /Claims/Submit.
2.Fill in the required fields (Employee ID, Claim Period, Hours Worked, Hourly Rate).
3.Submit the form.
4.If successful, you'll be redirected to a "Success" page.

-----------------------------------------------------------------------------------------------------

Conclusion
That’s it! The project should now be running locally, and you should be able to submit and store claim information in the database. If you encounter any issues, check the troubleshooting section or review the setup instructions.
