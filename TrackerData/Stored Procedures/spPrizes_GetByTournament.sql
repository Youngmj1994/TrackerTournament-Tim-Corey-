USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPrizes_GetByTournament]    Script Date: 7/22/2020 1:35:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spPrizes_GetByTournament]
	@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT		[Prizes].[Id], 
				[Prizes].[PlaceNumber], 
				[Prizes].[PlaceName], 
				[Prizes].[PrizeAmount], 
				[Prizes].[PrizePercentage]
	FROM		[dbo].[Prizes]
	INNER JOIN	[dbo].[TournamentPrizes]
	ON			TournamentPrizes.PrizeId = Prizes.Id
	WHERE		TournamentPrizes.TournamentId = @TournamentId;

END