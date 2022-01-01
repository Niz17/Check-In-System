CREATE PROCEDURE [dbo].[Update_ISC_Staff]
@ID int, 
@IC_Name varchar(255) = null, 
@Email varchar(255) = null, 
@OfficeNum int = null, 
@LoginID varchar(255) = null

AS 
BEGIN 
SET NOCOUNT ON

UPDATE [dbo].[ISC_Staff]
SET 
IC_Name = isNull(@IC_Name,IC_Name),
Email = isNull(@Email, Email),
OfficeNum = isNull(@OfficeNum, OfficeNum),
LoginID = isNUll(@LoginID, LoginID)
WHERE ID = @ID
END
