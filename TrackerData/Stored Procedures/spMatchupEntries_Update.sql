USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_Update]    Script Date: 7/22/2020 1:29:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spMatchupEntries_Update]
	@Id int,
	@TeamCompetingId int,
	@Score int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE	[dbo].[MatchupEntries]
	SET		TeamCompetingId = @TeamCompetingId,
			Score = @Score 
	WHERE	Id = @Id;

END
