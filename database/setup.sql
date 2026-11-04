-- Development-only starter schema reconstructed from available coursework source.
-- NOT the original database backup; different forms refer to different legacy tables.
-- Execute in SSMS against a local SQL Server instance.

IF DB_ID(N'LeaveManagementSystem') IS NULL
    EXEC(N'CREATE DATABASE LeaveManagementSystem');
GO
USE LeaveManagementSystem;
GO
IF OBJECT_ID(N'dbo.Employee_Details', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Employee_Details (
        Employee_ID INT NOT NULL PRIMARY KEY,
        Employee_Name NVARCHAR(100) NULL,
        [Password] NVARCHAR(255) NULL,
        Annual_Leaves INT NOT NULL DEFAULT (30),
        Casual_Leaves INT NOT NULL DEFAULT (12),
        Short_Leaves INT NOT NULL DEFAULT (6)
    );
END;
GO

IF OBJECT_ID(N'dbo.TableLeave', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.TableLeave (
        Leave_ID INT IDENTITY(1,1) PRIMARY KEY,
        Employee_ID INT NOT NULL,
        Leave_Type NVARCHAR(60) NOT NULL,
        Reason NVARCHAR(1000) NULL,
        Leave_Start DATE NOT NULL,
        Leave_End DATE NOT NULL,
        [Status] NVARCHAR(30) NOT NULL DEFAULT (N'Pending'),
        CONSTRAINT FK_TableLeave_Employee FOREIGN KEY (Employee_ID)
            REFERENCES dbo.Employee_Details(Employee_ID)
    );
END;
GO

-- Alternate form (Leave_Apply.cs) uses a legacy table with a different name.
IF OBJECT_ID(N'dbo.Leave_Table', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Leave_Table (
        Leave_ID INT IDENTITY(1,1) PRIMARY KEY,
        Employee_ID INT NOT NULL,
        Employee_Name NVARCHAR(100) NULL,
        Leave_Type NVARCHAR(60) NULL,
        Reason NVARCHAR(1000) NULL,
        Leave_Start DATE NULL,
        Leave_End DATE NULL,
        [Status] NVARCHAR(30) NOT NULL DEFAULT (N'Pending')
    );
END;
GO

-- The leave-balance prototype reads this naming convention, not TableLeave.
-- Some DataSet-generated queries expect a different Leaves schema.
IF OBJECT_ID(N'dbo.Leaves', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Leaves (
        Leave_ID INT IDENTITY(1,1) PRIMARY KEY,
        EmployeeID INT NULL,
        Employee_Number INT NULL,
        LeaveType NVARCHAR(60) NULL,
        Leave_Type NVARCHAR(60) NULL,
        LeaveStart DATE NULL,
        LeaveEnd DATE NULL,
        Leave_Date DATE NULL,
        [Status] NVARCHAR(30) NULL
    );
END;
GO

-- No credentials, employees or real leave data are seeded.
-- This script only provides a starting point: reconcile form SQL/typed DataSets
-- with the actual desired schema before claiming end-to-end functionality.
