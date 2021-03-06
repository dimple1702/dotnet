
-- deleting a databse
DROP DATABASE SCHOOL;

--creating a database
CREATE DATABASE School;

-- using database on which we want to perform operations
Use School;

-- creating table country
CREATE TABLE countries (
	country_id INT IDENTITY(1,1) PRIMARY KEY,
	country_code CHAR (2),
	country_name VARCHAR (40) DEFAULT NULL,
	region_name VARCHAR(25) DEFAULT NULL
);

-- creating new Table Country
CREATE TABLE Country (
	CountryId INT IDENTITY(1,1) PRIMARY KEY,
	CountryCode CHAR (2),
	CountryName VARCHAR (40) DEFAULT NULL,
	RegionName VARCHAR(25) DEFAULT NULL
);

-- copying the data of one table into another
INSERT INTO Country(CountryCode, CountryName, RegionName)
SELECT country_code, country_name, region_name
FROM countries;

-- creating table Location
CREATE TABLE [Location] (
	LocId INT IDENTITY(1,1) PRIMARY KEY,
	[Address] VARCHAR (50) DEFAULT NULL,
	PinCode VARCHAR (50) DEFAULT NULL,
	City VARCHAR (30) NOT NULL,
	CountryId INT NOT NULL,
	FOREIGN KEY (CountryId) REFERENCES Country (CountryId) ON DELETE CASCADE ON UPDATE CASCADE
);

-- creating table Department
CREATE TABLE Department (
	DeptId INT IDENTITY(1,1) PRIMARY KEY,
	DeptName VARCHAR (30) NOT NULL,
);

-- creating table Teacher
CREATE TABLE Teacher (
	TeacherId INT Identity(1,1) PRIMARY KEY,
	TeacherFname VARCHAR(50) NOT NULL,
	TeacherLname VARCHAR(50) NOT NULL,
	Email VARCHAR (100) NOT NULL,
	TeacherPhoneNo VARCHAR (20) DEFAULT NULL,
	HireDate DATE NOT NULL,
	DeptId INT NOT NULL,
	LocId INT NOT NULL,
	FOREIGN KEY (DeptId) REFERENCES Department (DeptId) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (LocId) REFERENCES [Location] (LocId) ON DELETE CASCADE ON UPDATE CASCADE
);

-- creating table Student
CREATE TABLE Student (
	StudentId INT IDENTITY(1,1) PRIMARY KEY,
	StudentFname varchar(30) DEFAULT NULL,
	StudentLname varchar(30) NOT NULL,
	StudentEmail varchar(50) NOT NULL,
	StudentPhoneNo varchar(20) DEFAULT NULL,
	StudentDob  DATE NOT NULL,
	TeacherId int DEFAULT NULL,
	LocId int DEFAULT NULL,
	FOREIGN KEY (TeacherId) REFERENCES Teacher (TeacherId) ON DELETE NO ACTION ON UPDATE NO ACTION,
	FOREIGN KEY (LocId) REFERENCES [Location] (LocId) ON DELETE NO ACTION ON UPDATE NO ACTION,
);