# Yape Reto: Local Environment Setup Guide

## Steps to Run This Project Locally

### 1. Clone the Following Repositories
- [YapeRetoSoapWCF](https://github.com/nudiermena/YapeRetoSoapWCF.git)
- [YapeRetoApiCore8](https://github.com/nudiermena/YapeRetoApiCore8.git)

### 2. Create the Database
You need to set up a SQL Server database to store and query data. Run the following SQL script on your SQL Server instance:

```sql
CREATE DATABASE YapePersons;
GO

USE [YapePersons]
GO

CREATE TABLE [dbo].[People](
    [Id] [uniqueidentifier] NOT NULL DEFAULT (newid()),
    [CellPhoneNumber] [varchar](20) NOT NULL,
    [Name] [varchar](50) NOT NULL,
    [LastName] [varchar](50) NULL,
    [DocumentType] [varchar](50) NOT NULL,
    [DocumentNumber] [varchar](50) NOT NULL,
    [ReasonOfUse] [varchar](50) NULL,
    CONSTRAINT [index_people] PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
```

### 3. Update Connection Strings
After creating the database and table, update the ConnectionStrings in both solutions:

Yape.WCFService
Yape.RestApi
Ensure the connection strings point to the correct SQL Server instance and database.

### 4. Open the Projects
Open the YapeRetoSoapWCF project using Visual Studio 2019.
Open the YapeRetoApiCore8 project using Visual Studio 2022.
Prerequisites
.NET Framework 4.8 (for the WCF project).
.NET Core 8 (for the REST API project).

### 5. Run the Solutions
Run both solutions simultaneously.
Use the Swagger UI provided by the .NET Core REST API project to send requests to the SOAP WCF service.

### Notes
Ensure that SQL Server is running and accessible.
Double-check that the connection strings are properly configured in both solutions.
Both services need to run concurrently for the system to work correctly.

