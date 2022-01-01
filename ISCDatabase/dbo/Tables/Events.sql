CREATE TABLE [dbo].[Events] (
    [ID]   INT           NOT NULL,
    [Name] VARCHAR (255) NOT NULL,
    [C_ID] INT           NOT NULL,
    [Date] DATETIME2 (2) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([C_ID]) REFERENCES [dbo].[Clubs] ([ID])
);

