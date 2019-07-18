/*
drop database if exists Exam
drop table if exists Spartans

create database Exam
create table Spartans(
	SpartanID int IDENTITY PRIMARY KEY,
	Title nvarchar(50),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	University nvarchar(100),
	Course nvarchar(50),
	Mark int
)

SET IDENTITY_INSERT Spartans ON
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (1, 'Dr.', 'Toby', 'Soutar', 'University Of Michigan', 'Geology', 1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (2, 'Pastor', 'Kyro', 'Newman', 'University of the Arts of London', 'Games Design', 1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (3, 'Dr.', 'Alex', 'Johnson', 'University of Brunel', 'Games Design', 1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (4, 'Fr.', 'Liam', 'Russell', 'University of College', 'Games Design', 2.1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (5, 'Miss.', 'Brooke', 'Harris', 'University of Westminster', 'Computing', 2.1);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (6, 'Professor', 'Sam', 'Ige', 'University of Swansea', 'Chemical Engineering', 2.2);
INSERT INTO Spartans (SpartanID,Title,FirstName,LastName,University,Course,Mark) Values (7, 'Eng.', 'Sanru', 'Mathybalan', 'University of Cardiff', 'Software Engineering', 2.2);
SET IDENTITY_INSERT Spartans OFF

select * from Spartans */