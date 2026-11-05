# Leave Management System

A C# desktop application for submitting employee leave requests and reviewing leave records in SQL Server.

The employee interface captures leave type, dates and reason, and lets employees look up their requests. The [screen gallery](docs/screenshots/README.md) also documents the administrator interface designed for the project.

**Technologies**  
C# · Windows Forms · ADO.NET · SQL Server

![Leave request form](docs/screenshots/employee/apply-leave.png)

## Run locally

Open `LeaveManagementSystem.sln` on Windows with Visual Studio and the .NET Framework 4.7.2 targeting pack. Run `database/setup.sql` on a local SQL Server Express instance and add a fictional employee login. Configure the forms and project settings for your instance, then build and start the employee application. See the [database model](docs/DATABASE_MODEL.md) and [implementation notes](docs/KNOWN_LIMITATIONS.md) for schema differences between forms.

## Author

Maleesha Dewmina Perera
