CREATE PROCEDURE [dbo].[usp_CalculateStudentVisitors]

AS
BEGIN
	SELECT count(S.ID) AS StudentCount
	FROM Student S
	JOIN StudentVisits SV ON S.ID = SV.StudentID
	JOIN Visits V ON V.ID = SV.V_ID
END
