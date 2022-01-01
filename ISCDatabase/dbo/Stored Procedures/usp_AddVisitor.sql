CREATE PROCEDURE [dbo].[usp_AddVisitor] 
@name varchar(255), 
@email varchar(255),
@purpose varchar(255)

AS
SET NOCOUNT ON
DECLARE @vid int, @visitorId int

IF EXISTS (SELECT * FROM [dbo].[Visitor] v1 WHERE @Email = V1.[Email])
BEGIN
	INSERT INTO dbo.[Visits]([Purpose], [EntryTime])
				VALUES (@purpose, GETUTCDATE())

	SELECT @vid = SCOPE_IDENTITY()

	SELECT @visitorID = v2.[Id] FROM [dbo].[Visitor] v2 WHERE @Email = V2.[Email]

	INSERT INTO dbo.[OtherVisits]([V_ID], [VisitorID])
	VALUES (@vid, @visitorId)

END						
ELSE
BEGIN
INSERT INTO [dbo].[Visitor]
	([VName]
	,[Email])
VALUES
	(@name
	,@Email)

	SELECT @visitorId = SCOPE_IDENTITY()

	INSERT INTO dbo.[Visits]([Purpose], [EntryTime])
				VALUES (@purpose, GETUTCDATE())

	SELECT @vid = SCOPE_IDENTITY()

	SELECT @visitorID = v2.[Id] FROM [dbo].[Visitor] v2 WHERE @Email = V2.[Email]
	INSERT INTO dbo.[OtherVisits]([V_ID], [VisitorID])
	VALUES (@vid, @visitorId)
END

