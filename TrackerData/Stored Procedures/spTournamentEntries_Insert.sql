USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournamentEntries_Insert]    Script Date: 7/22/2020 1:40:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTournamentEntries_Insert]
	@TournamentId int,
	@TeamId int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[TournamentEntries] (TournamentId, TeamId)
	VALUES (@TournamentId, @TeamId)

	SELECT @Id = SCOPE_IDENTITY();

END