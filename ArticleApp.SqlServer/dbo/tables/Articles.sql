﻿CREATE TABLE [dbo].[Articles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Title] NVARCHAR(255) NOT NULL, 
    [Content] NVARCHAR(MAX) NOT NULL,
    [IsPinned] BIT NOT NULL DEFAULT 0, 

    [CreatedBy] NVARCHAR(255) NULL, 
    [Created] DATETIME NOT NULL DEFAULT GetDate(), 
    [ModifiedBy] NVARCHAR(255) NULL, 
    [Modified] DATETIME NULL, 
)
Go