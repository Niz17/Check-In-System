
CREATE PROCEDURE [dbo].[usp_GetStudentVisits]
	
AS
SET NOCOUNT ON
BEGIN
	SELECT V.ID, 
			S.[SName] as [Name], 
			V.[Purpose], 
			IC.[IC_Name] as [VisitingName], 
			V.[EntryTime]
	FROM dbo.[Visits] V
	INNER JOIN [StudentVisits] SV ON V.ID = SV.[V_ID]
	INNER JOIN [Student] S ON S.[ID] = SV.[StudentID]
	LEFT OUTER JOIN [ISC_Staff] IC ON IC.[ID] = V.[IC_ID]
END
