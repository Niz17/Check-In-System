CREATE PROCEDURE [dbo].[usp_GetVisitorVisits]
	
AS
SET NOCOUNT ON
BEGIN
	SELECT V.ID, 
			VS.[VName] as [Name], 
			V.[Purpose], 
			IC.[IC_Name] as [VisitingName], 
			V.[EntryTime]
	FROM dbo.[Visits] V
	INNER JOIN [OtherVisits] OV ON V.ID = OV.[V_ID] 
	INNER JOIN [Visitor] VS ON VS.[ID] = OV.[VisitorID]
	LEFT OUTER JOIN [ISC_Staff] IC ON IC.[ID] = V.[IC_ID]
END
