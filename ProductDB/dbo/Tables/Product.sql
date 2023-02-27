CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] VARCHAR(50) NOT NULL, 
    [Description] NCHAR(10) NOT NULL, 
    FOREIGN KEY (Id) REFERENCES  Categories(Id)
    
)
