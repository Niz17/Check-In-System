CREATE PROCEDURE [dbo].[Update_Events]
@ID int, 
@Name varchar(255) = null, 
@C_ID int = null, 
@Date datetime2(2) = null

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[Events]
SET
Name = isNull(@Name, Name),
C_ID = isNull (@C_ID, C_ID),
Date = isNull (@Date, Date)
WHERE ID = @ID

END
