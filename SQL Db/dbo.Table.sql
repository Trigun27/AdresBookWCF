CREATE TABLE [dbo].[Contacts]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(MAX) NOT NULL, 
    [MiddleName] NVARCHAR(MAX) NOT NULL, 
    [LastName] NVARCHAR(MAX) NOT NULL, 
    [PhoneNumber] NVARCHAR(MAX) NOT NULL
)
