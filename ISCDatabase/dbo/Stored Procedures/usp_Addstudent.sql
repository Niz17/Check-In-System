CREATE PROCEDURE [dbo].[usp_Addstudent]
	@id int ,
	@name VARCHAR(50),
	@email VARCHAR(50),
	@purpose varchar(255)
AS
SET NOCOUNT ON
DECLARE @vid int

IF EXISTS (SELECT * FROM [dbo].[Student] S WHERE @id = S.[ID])
BEGIN
	INSERT INTO dbo.[Visits]([Purpose], [EntryTime])
				VALUES (@purpose, GETUTCDATE())

	SELECT @vid = SCOPE_IDENTITY()

	INSERT INTO dbo.[StudentVisits]([V_ID], [StudentID])
	VALUES (@vid, @id)

END						
ELSE
BEGIN
INSERT INTO [dbo].[Student]
	([ID]
	,[SName]
	,[Email])
VALUES
	(@id
	,@name
	,@Email)

	INSERT INTO dbo.[Visits]([Purpose], [EntryTime])
				VALUES (@purpose, GETUTCDATE())

	SELECT @vid = SCOPE_IDENTITY()

	INSERT INTO dbo.[StudentVisits]([V_ID], [StudentID])
	VALUES (@vid, @id)
END



