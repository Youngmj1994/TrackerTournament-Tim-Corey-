USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spTeams_Insert]    Script Date: 7/22/2020 1:40:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spTeams_Insert]
	@TeamName nvarchar(100),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Teams] (TeamName)
	VALUES (@TeamName)

	SELECT @Id = SCOPE_IDENTITY();
END
