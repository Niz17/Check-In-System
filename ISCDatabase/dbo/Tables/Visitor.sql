﻿CREATE TABLE [dbo].[Visitor] (
    [Id] int NOT NULL IDENTITY(1,1),
    [VName] VARCHAR (255) NOT NULL,
    [Email] VARCHAR (255) NOT NULL UNIQUE,
    PRIMARY KEY CLUSTERED ([Id] ASC),
);

