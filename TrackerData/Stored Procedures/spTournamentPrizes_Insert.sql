USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournamentPrizes_Insert]    Script Date: 7/22/2020 1:52:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTournamentPrizes_Insert]
	@TournamentId int,
	@PrizeId int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TournamentPrizes] (TournamentId, PrizeId)
	VALUES (@TournamentId, @PrizeId);

	SELECT @Id = SCOPE_IDENTITY();
END