USE [Tournaments]
GO
/****** Object:  StoredProcedure [dbo].[spPrizes_Insert]    Script Date: 7/22/2020 1:36:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spPrizes_Insert]
	@PlaceNumber int, 
	@PlaceName nvarchar(50), 
	@PrizeAmount money, 
	@PrizePercentage float,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Prizes] (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);

	SELECT @Id = SCOPE_IDENTITY();

END