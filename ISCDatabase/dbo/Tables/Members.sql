CREATE TABLE [dbo].[Members] (
    [C_ID]      INT NOT NULL,
    [StudentID] INT NOT NULL,
    FOREIGN KEY ([C_ID]) REFERENCES [dbo].[Clubs] ([ID]),
    FOREIGN KEY ([StudentID]) REFERENCES [dbo].[Student] ([ID])
);

