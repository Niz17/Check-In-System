CREATE PROCEDURE [dbo].[usp_calculateOthersLastMonth]

AS
BEGIN
	SELECT count(VS.ID) AS StudentCount
	FROM Visitor VS
	JOIN OtherVisits OV ON VS.ID = OV.VisitorID
	JOIN Visits V ON V.ID = OV.V_ID
	WHERE DATEDIFF(month, V.EntryTime, GETUTCDATE()) <= 1
END
