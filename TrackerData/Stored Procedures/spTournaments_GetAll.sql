USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_GetAll]    Script Date: 7/22/2020 1:54:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTournaments_GetAll]
AS
BEGIN

	SET NOCOUNT ON;
	
	SELECT	Tournaments.Id, 
			Tournaments.TournamentName, 
			Tournaments.EntryFee, 
			Tournaments.Active
	FROM	[dbo].[Tournaments]
	WHERE	Active = 1;

END