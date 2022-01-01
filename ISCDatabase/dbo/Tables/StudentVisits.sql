CREATE TABLE [dbo].[StudentVisits] (
    [V_ID]      INT NULL,
    [StudentID] INT NULL,
    FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Student] ([ID]),
    FOREIGN KEY ([V_ID]) REFERENCES [dbo].[Visits] ([ID])
);

