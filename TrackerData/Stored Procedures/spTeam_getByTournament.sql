USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeam_getByTournament]    Script Date: 7/22/2020 1:37:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTeam_getByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT		[Teams].[Id], 
				[Teams].[TeamName]
	FROM		[dbo].[Teams]
	INNER JOIN	[dbo].[TournamentEntries]
	ON			TournamentEntries.TeamId = Teams.Id
	WHERE		[TournamentEntries].[TournamentId] = @TournamentId;

END