CREATE PROCEDURE [dbo].[usp_calculateStudentsLastMonth]

AS
BEGIN
	SELECT count(S.ID) AS StudentCount
	FROM Student S
	JOIN StudentVisits SV ON S.ID = SV.StudentID
	JOIN Visits V ON V.ID = SV.V_ID
	WHERE DATEDIFF(month, V.EntryTime, GETUTCDATE()) <= 1
END
