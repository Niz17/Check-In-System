CREATE PROCEDURE [dbo].[Update_Clubs]
@ID int, 
@Name varchar(255) = null, 
@President_ID int = null

AS
BEGIN
SET NOCOUNT ON

UPDATE [dbo].[Clubs]
SET
Name = isNull(@Name, Name),
President_ID = isNull (@President_ID, President_ID)
WHERE ID = @ID

END
