USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spMatchups_Update]    Script Date: 7/22/2020 1:34:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spMatchups_Update]
	@Id int,
	@WinnerId int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Matchups]
	SET WinnerId = @WinnerId
	WHERE id = @id;

END