﻿CREATE TABLE [dbo].[UserInfoTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY DEFAULT NULL, 
    [FirstName] VARCHAR(50) NOT NULL DEFAULT NULL, 
    [LastName] VARCHAR(50) NOT NULL DEFAULT NULL, 
    [UserID] VARCHAR(50) NOT NULL DEFAULT NULL, 
    [UserPass] VARCHAR(50) NOT NULL DEFAULT NULL
)