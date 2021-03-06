USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeamMembers_GetByTeam]    Script Date: 7/22/2020 1:37:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTeamMembers_GetByTeam]
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT		[People].[Id], 
				[People].[FirstName], 
				[People].[LastName], 
				[People].[EmailAddress], 
				[People].[CellphoneNumber]
	FROM		[dbo].[TeamMembers]
	INNER JOIN	[dbo].[People]
	ON			[People].[Id] = [TeamMembers].[PersonId]
	WHERE		[TeamMembers].[TeamId] = @TeamId;

END