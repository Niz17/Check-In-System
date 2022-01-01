CREATE TABLE [dbo].[Visits] (
    [ID]        INT           IDENTITY(1,1) PRIMARY KEY NOT NULL,
    [Purpose]   VARCHAR (255) NULL,
    [IC_ID]     INT           NULL,
    [EntryTime] DATETIME2 (2) NULL,
    FOREIGN KEY ([IC_ID]) REFERENCES [dbo].[ISC_Staff] ([ID])
);

