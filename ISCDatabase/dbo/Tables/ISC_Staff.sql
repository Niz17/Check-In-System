CREATE TABLE [dbo].[ISC_Staff] (
    [ID]        INT           NOT NULL,
    [IC_Name]   VARCHAR (255) NOT NULL,
    [Email]     VARCHAR (255) NOT NULL,
    [OfficeNum] INT           NOT NULL,
    [LoginID]   VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([LoginID]) REFERENCES [dbo].[LoginInfo] ([LoginID])
);

