CREATE TABLE [dbo].[OtherVisits] (
    [V_ID]     INT           NULL,
    [VisitorID] INT NULL,
    FOREIGN KEY ([V_ID]) REFERENCES [dbo].[Visits] ([ID]),
    FOREIGN KEY ([VisitorID]) REFERENCES [dbo].[Visitor] ([ID])
);

