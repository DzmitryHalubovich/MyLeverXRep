use master
go

CREATE DATABASE UniversityDb
GO

use UniversityDb
GO

CREATE TABLE City(
	CityID int PRIMARY KEY IDENTITY,
	Name NVARCHAR(20) NOT NULL,
	Population int NOT NULL 
)

CREATE TABLE Subject(
	SubjectID int PRIMARY KEY IDENTITY,
	Name NVARCHAR(20) NOT NULL,
	Duration NVARCHAR(10) NOT NULL
)

CREATE TABLE University(
	UniversityID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(40) NOT NULL,
	Address NVARCHAR (20) NOT NULL,
	CityID Int NOT NULL FOREIGN KEY REFERENCES City(CityID)
)

CREATE TABLE [Group](
	GroupID int PRIMARY KEY IDENTITY,
	Name NVARCHAR(20) NOT NULL,
	UniversityId int NOT NULL  FOREIGN KEY REFERENCES University(UniversityID)
)


CREATE TABLE Teacher(
	TeacherID Int Not null PRIMARY KEY IDENTITY,
	Name NVARCHAR(20) NOT NULL,
	Phone INT NOT NULL,
	SubjectID INT NOT NULL FOREIGN KEY REFERENCES Subject(SubjectID)
)

CREATE TABLE UniversityTeacher(
	TeacherID INT FOREIGN KEY REFERENCES Teacher(TeacherID),
	UniversityID INT NOT NULL FOREIGN KEY REFERENCES University(UniversityID),
	Wage INT NOT NULL
	CONSTRAINT PK PRIMARY KEY(TeacherID, UniversityID)
)

CREATE TABLE Student(
	StudentID INT PRIMARY KEY,
	Name NVARCHAR(40) NOT NULL,
	Birthday Date NULL,
	Bursary int NOT NULL,
	Bonus int null,
	CityID int not null foreign key references City(CityID),
	GroupID int not null --foreign key references Group(GroupID)
)

CREATE TABLE StudentSubject(
	StudentID INT FOREIGN KEY REFERENCES Student(StudentID),
	SubjectID INT FOREIGN KEY REFERENCES Subject(SubjectID),
	Mark INT NOT NULL 
	CONSTRAINT PK1 PRIMARY KEY(StudentID, SubjectID)
)

