CREATE PROCEDURE [dbo].[INSERT_Events] @ID int, @Name varchar(255), @C_ID int, @Date DateTime

AS

/*
----------------------------------------------------------------------------
-- Object Name: dbo.INSERT_Events
-- Project: ISC Check-In System
-- Business Process: 
-- Purpose: Insert the student record into the table
-- Detailed Description: Insert the student record into the dbo.OtherVisits table
-- Database: ISC
-- Dependent Objects: None
-- Called By: Ad-hoc
-- Upstream Systems: N\A
-- Downstream Systems: N\A
-- 
--------------------------------------------------------------------------------------
-- Rev | CMR | Date Modified | Developer 
--------------------------------------------------------------------------------------
-- 001 | N\A | 11.16.2021 | Nshakya23 | 
-- Modified from: https://www.mssqltips.com/sqlservertutorial/2519/insert-stored-procedure-in-sql-server/
--
*/

/* Indicates SQL Server not to return the number of rows affected. */
SET NOCOUNT ON

INSERT INTO [dbo].[Events]
	([ID]
	,[Name]
	,[C_ID]
	,[Date])
VALUES
	(@ID
	,@Name
	,@C_ID
	,@Date)
