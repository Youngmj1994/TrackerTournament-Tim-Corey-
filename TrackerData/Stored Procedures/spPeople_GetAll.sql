USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPeople_GetAll]    Script Date: 7/22/2020 1:35:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spPeople_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	[People].[Id], 
			[People].[FirstName], 
			[People].[LastName], 
			[People].[EmailAddress], 
			[People].[CellphoneNumber]
	FROM	[dbo].[People];
END