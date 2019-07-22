use master
drop database if exists ConnectFour
drop table if exists PlayerOne
drop table if exists PlayerTwo
drop table if exists Players

create database ConnectFour
go
use ConnectFour;

create table Players(
	PlayerID int PRIMARY KEY,
	PlayerName NVARCHAR(25),
	Wins INT,
	Losses INT
)

create table PlayerOne(
	PlayerOneID int PRIMARY KEY,
	PlayerName NVARCHAR(25),
	Wins INT,
	Losses INT,
	FOREIGN KEY (PlayerID) REFERENCES Players (PlayerID),
)

create table PlayerTwo(
	PlayerTwoID int PRIMARY KEY,
	PlayerName NVARCHAR(25),
	Wins INT,
	Losses INT,
	FOREIGN KEY (PlayerID) REFERENCES Players (PlayerID),
)