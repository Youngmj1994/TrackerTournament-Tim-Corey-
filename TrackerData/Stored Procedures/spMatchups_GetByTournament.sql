USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_GetByTournament]    Script Date: 7/22/2020 1:29:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spMatchups_GetByTournament]
	@TournamentId int
AS
BEGIN 

	SET NOCOUNT ON;

	SELECT		[Matchups].[Id], 
				[Matchups].[TournamentId], 
				[Matchups].[WinnerId], 
				[Matchups].[MatchupRound]
	FROM		[dbo].[Matchups]
	WHERE		Matchups.TournamentId = @TournamentId
	ORDER BY	Matchups.MatchupRound;

END
