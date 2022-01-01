
CREATE PROCEDURE [dbo].[usp_GetEmployeeVisits]
	
AS
SET NOCOUNT ON
BEGIN
	SELECT V.ID, 
		E.[EName] as [Name], 
		V.[Purpose], 
		IC.[IC_Name] as [VisitingName], 
		V.[EntryTime]
	FROM dbo.[Visits] V
	INNER JOIN [EmpVisits] EV ON V.ID = EV.[V_ID]
	INNER JOIN [Employee] E ON E.[ID] = EV.[EmpID]
	LEFT OUTER JOIN [ISC_Staff] IC ON IC.[ID] = V.[IC_ID]
END