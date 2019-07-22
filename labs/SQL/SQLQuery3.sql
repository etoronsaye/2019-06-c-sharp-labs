drop database if exists SpartaAcademy
drop table if exists CourseScheduleAttendees
drop table if exists CourseScheduleTrainers
drop table if exists dbo.CourseSchedule
drop table if exists Employees
drop table if exists CourseCatalog
drop table if exists Rooms
drop table if exists Academies

create database SpartaAcademy

-- Course  StartDate  EndDate  Academy  Room  Trainer  Spartan 
use SpartaAcademy;
create table Academies(
	-- AcademyID int IDENTITY PRIMARY KEY,
	AcademyName NVARCHAR(50)
)

create table Rooms(
	AcademyID int,
	RoomName NVARCHAR (50),
	[Description] NVARCHAR(50),
	Capacity int
)

create table CourseCatalog(
	CourseID int,
	CourseName NVARCHAR(50),
	Duration int
)

create table Employees(
	FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    EmployeeType NVARCHAR(5),
    StartDate DATETIME
)

create table dbo.CourseSchedule(
	AcademyID int,
	RoomID int,
	CourseID int,
	StartDate datetime,
	EndDate datetime
)

create table CourseScheduleTrainers(
	CourseScheduleID int,
	TrainerID int,
	TrainerType NVARCHAR(5)
)

create table CourseScheduleAttendees(
	CourseScheduleID int,
	AttendeeID int,
	Active int
)

INSERT INTO [Rooms] ([AcademyID], [RoomName], [Description], [Capacity]) VALUES (1, 'Room 1', 'Next to the new Lo; sign', 12);
INSERT INTO [Rooms] ([AcademyID], [RoomName], [Description], [Capacity]) VALUES (1, 'Room 2', 'Behind the new Sparta sign', 18);
INSERT INTO [Rooms] ([AcademyID], [RoomName], [Description], [Capacity]) VALUES (1, 'Room 3', 'No air-con', 18);
INSERT INTO [Rooms] ([AcademyID], [RoomName], [Description], [Capacity]) VALUES (1, 'Room 4', 'Has second door with number lock', 10);
INSERT INTO [Rooms] ([AcademyID], [RoomName], [Description], [Capacity]) VALUES (1, 'Boardroom', 'Use as last resort', 14);

INSERT INTO [Academies] ([AcademyName]) VALUES ('Richmond');
INSERT INTO [Academies] ([AcademyName]) VALUES ('Birmingham');
INSERT INTO [Academies]  ([AcademyName]) VALUES ('Leeds');

INSERT INTO [CourseCatalog] ([CourseName], [Duration]) VALUES ('BA-Test', 7);
INSERT INTO [CourseCatalog] ([CourseName], [Duration]) VALUES ('Engineering', 12);

INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Tim','Cawte','T','07/14/2017');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Richard', 'Gurney', 'T', '07/01/2017');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Adam','Smith','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('John','Williams','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Nick','Willis','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Jenny','Jones','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Katie','Prince','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Peter','Brown','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Mo','Khan','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Juan','Carlos','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Jan','Miller','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Kyle','Carpenter','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Alvarao','Carlos','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Margaret','Baker','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Oti','Mwase','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Joe','Mann','S');
INSERT INTO [Employees] ([FirstName], [LastName], [EmployeeType], [StartDate]) VALUES ('Steve','Harris','S');

INSERT INTO [dbo].[CourseSchedule] ([AcademyID], [RoomID], [CourseID], [StartDate], [EndDate]) VALUES (1, 1, 1, '01/15/2018', '03/02/2018');
INSERT INTO [dbo].[CourseSchedule] ([AcademyID], [RoomID], [CourseID], [StartDate], [EndDate]) VALUES (1, 3, 2, '01/22/2018', '03/03/2018');

INSERT INTO [CourseScheduleTrainers] ([CourseScheduleID], [TrainerID], [TrainerType]) VALUES (1, 1, 'T');
INSERT INTO [CourseScheduleTrainers] ([CourseScheduleID], [TrainerID], [TrainerType]) VALUES (2, 2, 'T');

INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (1, 3, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUEs (1, 4, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (1, 5, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (1, 6, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (1, 7, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (1, 8, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 9, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 10, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 11, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 12, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 13, 1);
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 14, 1); 
INSERT INTO [CourseScheduleAttendees] ([CourseScheduleID], [AttendeeID], [Active]) VALUES (2, 15, 1);

select * from Academies
select * from Rooms
select * from CourseCatalog
select * from Employees
select * from dbo.CourseSchedule
select * from CourseScheduleTrainers
select * from CourseScheduleAttendees
/*create table Spartans(
	SpartanID int IDENTITY PRIMARY KEY,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	CourseID int FOREIGN KEY (CourseID) REFERENCES Course (CourseID)
)

create table StartDate(
	StartDate datetime,
	CourseID int FOREIGN KEY (CourseID) REFERENCES Course (CourseID)
)

create table EndDate(
	EndDate datetime,
	CourseID int FOREIGN KEY (CourseID) REFERENCES Course (CourseID)
)*/

/*SET IDENTITY_INSERT Academy ON
INSERT INTO Academy (AcademyID, AcademyName) Values (1, 'Richmond');
SET IDENTITY_INSERT Academy OFF

SET IDENTITY_INSERT Room ON
INSERT INTO Room (RoomID, RoomName) Values (1, 'Room 1');
INSERT INTO Room (RoomID, RoomName) Values (2, 'Room 2');
SET IDENTITY_INSERT Room OFF

SET IDENTITY_INSERT Course ON
INSERT INTO Course (CourseID, StartDate, EndDate, CourseName, AcademyID) Values (1, 2018-01-15, 2018-03-02, 'BA-Test', 1);
INSERT INTO Course (CourseID, StartDate, EndDate, CourseName, AcademyID) Values (1, 2018-01-22, 2018-03-03, 'Engineering', 2);
SET IDENTITY_INSERT Spartans OFF

SET IDENTITY_INSERT Trainer ON
INSERT INTO Trainer (TrainerID, TrainerName) Values (1, 'Tim Cawte');
INSERT INTO Trainer (TrainerID, TrainerName) Values (2, 'Richard Gurney');
SET IDENTITY_INSERT Trainer OFF

SET IDENTITY_INSERT Spartans ON
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (1, 'Toby', 'Soutar', 1);
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (2, 'Kyro', 'Newman', 1);
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (3, 'Alex', 'Johnson', 1);
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (4, 'Liam', 'Russell', 2);
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (5, 'Brooke', 'Harris', 2);
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (6, 'Sam', 'Ige', 2);
INSERT INTO Spartans (SpartanID,FirstName,LastName,CourseID) Values (7, 'Sanru', 'Mathybalan', 2);
SET IDENTITY_INSERT Spartans OFF*/