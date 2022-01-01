CREATE PROCEDURE [dbo].[usp_CalculateOtherVisitors]

AS
BEGIN
	SELECT count(VS.ID) AS StudentCount
	FROM Visitor VS
	JOIN OtherVisits OV ON VS.ID = OV.VisitorID
	JOIN Visits V ON V.ID = OV.V_ID
END
