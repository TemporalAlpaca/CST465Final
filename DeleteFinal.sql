CREATE PROCEDURE [dbo].[Pirates_Delete]
(
	@Id int
)
AS
DELETE FROM Pirates
WHERE Id=@Id;

CREATE PROCEDURE [dbo].[PirateAnimals_Delete]
(
	@Id int
)
AS
DELETE FROM PirateAnimals
WHERE Id=@Id;

CREATE PROCEDURE [dbo].[Links_Delete]
(
	@Id int
)
AS
DELETE FROM Links
WHERE Id=@Id;

