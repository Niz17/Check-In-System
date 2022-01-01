CREATE PROCEDURE [dbo].[usp_CalculateUniqueStudentVisitors]
AS
BEGIN
	SELECT count(Distinct S.ID) AS StudentCount
	FROM Student S
	JOIN StudentVisits SV ON S.ID = SV.StudentID
	JOIN Visits V ON V.ID = SV.V_ID
END
