CREATE PROCEDURE [dbo].[Pirates_Insert]
(
	@Name varchar(50),
	@BeardColor varchar(30),
	@CatchPhrase varchar (200),
    @HasHat bit,
	@HasEyepatch bit,
    @NumLegs int
)
AS
INSERT INTO Pirates([Name], BeardColor, CatchPhrase, HasHat, HasEyepatch, numLegs) 
VALUES (@Name, @BeardColor, @CatchPhrase, @HasHat, @HasEyepatch, @NumLegs);

CREATE PROCEDURE [dbo].[PirateAnimals_Insert]
(
	@Name varchar(50),
    @AnimalType varchar(50),
    @Age int,
	@SpeaksEnglish bit
)
AS
INSERT INTO PirateAnimals([Name], AnimalType, Age, SpeaksEnglish)
VALUES (@Name, @AnimalType, @Age, @SpeaksEnglish);

CREATE PROCEDURE [dbo].[Links_Insert]
(
	@LinkAddress varchar(400),
	@LinkName varchar(100),
	@PLevel int
)
AS
INSERT INTO Links(LinkAddress, LinkName, PLevel)
VALUES (@LinkAddress, @LinkName, @PLevel);