CREATE TABLE [dbo].[Table]
(
	[EmployeeID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [HireDate] DATETIME NOT NULL, 
    [Salary] MONEY NOT NULL, 
    [FullTime] BIT NOT NULL
)
