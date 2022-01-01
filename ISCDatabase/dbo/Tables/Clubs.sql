CREATE TABLE [dbo].[Clubs] (
    [ID]           INT        IDENTITY(1,1)   NOT NULL,
    [Name]         VARCHAR (255) NOT NULL,
    [President_ID] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([President_ID]) REFERENCES [dbo].[Student] ([ID])
);

