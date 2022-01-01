
CREATE PROCEDURE [dbo].[INSERT_LoginInfo] @LoginID varchar(255), @Password varchar(255)

AS

SET NOCOUNT ON

INSERT INTO [dbo].[LoginInfo]
	([LoginID]
	,[Password])
VALUES
	(@LoginID
	,@Password)
