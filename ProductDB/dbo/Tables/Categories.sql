﻿CREATE TABLE [dbo].[Categories]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CategoryName] VARCHAR(50) NOT NULL
	FOREIGN KEY (Id) REFERENCES  Products(Id)
)
