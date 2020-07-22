USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchupEntries_GetByMatchup]    Script Date: 7/22/2020 1:27:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spMatchupEntries_GetByMatchup]
@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;
	select [MatchupEntries].*
	from [dbo].[MatchupEntries]
	where [MatchupEntries].[MatchupId] = @MatchupId;
END
