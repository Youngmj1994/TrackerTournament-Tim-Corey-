USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTournaments_Complete]    Script Date: 7/22/2020 1:53:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTournaments_Complete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE [dbo].[Tournaments]
	SET Active = 0
	WHERE Id = @Id;

END