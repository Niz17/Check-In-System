
CREATE PROCEDURE [dbo].[usp_CheckLogin] (@id varchar(255), @pwd varchar(255))
AS

BEGIN
SELECT count(L.[LoginID]) AS ID_Count
FROM LoginInfo L
WHERE L.[LoginID] = @id and L.[Password] = @pwd
GROUP BY L.[LoginID]
END