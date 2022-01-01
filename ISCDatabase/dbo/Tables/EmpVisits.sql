CREATE TABLE [dbo].[EmpVisits] (
    [V_ID]  INT NULL,
    [EmpID] INT NULL,
    FOREIGN KEY ([EmpID]) REFERENCES [dbo].[Employee] ([ID]),
    FOREIGN KEY ([V_ID]) REFERENCES [dbo].[Visits] ([ID])
);

