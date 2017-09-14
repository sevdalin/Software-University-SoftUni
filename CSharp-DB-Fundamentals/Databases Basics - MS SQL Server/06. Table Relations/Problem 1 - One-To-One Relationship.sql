CREATE TABLE Persons
(
	PersonID int NOT NULL,
	FirstName varchar(50) NOT NULL,
	Salary money,
	PasspordID int
)

CREATE TABLE Passports
(
	PasportID int NOT NULL,
	PassportNumber varchar(50)
)

INSERT INTO Persons
VALUES (1, 'Roberto', 43300.00, 102), (2, 'Tom', 56100.00, 103), (3, 'Yana', 60200.00, 101)

INSERT INTO Passports
VALUES (101, 'N34FG21B'), (102, 'K65LO4R7'), (103, 'ZE657QP2')

ALTER TABLE Persons
ADD CONSTRAINT PK_PersonID
PRIMARY KEY (PersonID)

ALTER TABLE Passports
ADD CONSTRAINT PasportID
PRIMARY KEY (PasportID)

ALTER TABLE Persons
ADD CONSTRAINT FK_Persons_Passpords
FOREIGN KEY (PasspordID)
REFERENCES Passports(PasportID)
