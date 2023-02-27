CREATE TABLE [dbo].[Lists]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ListName] VARCHAR(50) NOT NULL, 
    [IsCompleted] BIT NOT NULL, 
    [CreationDate] DATETIME NULL, 
    [CompletionDate] DATETIME NULL,
    FOREIGN KEY (Id) REFERENCES Products(Id),
)
