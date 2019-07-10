drop database if exists taskDB
drop table if exists Tasks
drop table if exists Categories

create database taskDB

create table Categories(
	CategoryID INT IDENTITY PRIMARY KEY,
	CategoryName nvarchar(50) NOT NULL
)

create table tasks(
	TaskID INT IDENTITY PRIMARY KEY,
	description nvarchar(50) NULL,
	Done BIT NULL,
	CategoryID INT NULL,
	FOREIGN KEY (CategoryID) REFERENCES Categories (CategoryID)
)