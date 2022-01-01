CREATE PROCEDURE [dbo].[usp_CalculateUniqueOtherVisitors]
AS
BEGIN
	SELECT count(Distinct VS.ID) AS StudentCount
	FROM Visitor VS
	JOIN OtherVisits OV ON VS.ID = OV.VisitorID
	JOIN Visits V ON V.ID = OV.V_ID
END
