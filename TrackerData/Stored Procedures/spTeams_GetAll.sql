USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeams_GetAll]    Script Date: 7/22/2020 1:40:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTeams_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	[Teams].[Id], 
			[Teams].[TeamName]
	FROM	[dbo].[Teams];

END