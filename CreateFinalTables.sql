CREATE TABLE Pirates (
    Id int IDENTITY(1,1) PRIMARY KEY,
    [Name] varchar(50),
    BeardColor varchar(30),
	CatchPhrase varchar (200),
    HasHat bit,
	HasEyepatch bit,
    numLegs int
);

CREATE TABLE PirateAnimals (
    Id int IDENTITY(1,1) PRIMARY KEY,
    [Name] varchar(50),
    AnimalType varchar(50),
    Age int,
	SpeaksEnglish bit
);

CREATE TABLE Links (
    Id int IDENTITY(1,1) PRIMARY KEY,
	LinkAddress varchar(400),
	LinkName varchar(100),
	PLevel int
);