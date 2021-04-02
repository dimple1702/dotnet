CREATE DATABASE ApiPractice;

USE ApiPractice;


CREATE TABLE [User](
	UserId INT IDENTITY(1,1) PRIMARY KEY,
	UserName VARCHAR(50) NOT NULL,
	UserAge INT NOT NULL,
	UserGender CHAR(1) NOT NULL
);

INSERT INTO [User](UserName, UserAge, UserGender) VALUES('Dimple Verma', 21, 'F');
INSERT INTO [User](UserName, UserAge, UserGender) VALUES('Elena Gilbert', 19, 'F');
INSERT INTO [User](UserName, UserAge, UserGender) VALUES('Damon Salvatore', 21, 'M');

SELECT * FROM [User]; 

CREATE TABLE Ticket(
	TicketId INT IDENTITY(1,1) PRIMARY KEY,
	UserId INT NOT NULL,
	TicketSubject varchar(MAX) NOT NULL,
	TicketDescription varchar(MAX) NOT NULL,
	IsActive BIT DEFAULT 1

	FOREIGN KEY (UserId) REFERENCES [User] (UserId) ON DELETE NO ACTION ON UPDATE NO ACTION
);

INSERT INTO Ticket(UserId, TicketSubject, TicketDescription, IsActive) VALUES(2, 'Unable to connect to VPN', 'Connection to VPN can not be established', 1);
INSERT INTO Ticket(UserId, TicketSubject, TicketDescription, IsActive) VALUES(1, 'Test Ticket Updated', 'Your request for updating the test ticket is accessed and the ticked is is updated', 1);


SELECT * FROM Ticket;

CREATE TABLE [Role](
	RoleId INT IDENTITY(1,1) PRIMARY KEY,
	RoleName VARCHAR(50) NOT NULL
);

INSERT INTO [Role] VALUES('Admin');
INSERT INTO [Role] VALUES('Tester');
INSERT INTO [Role] VALUES('Developer');
INSERT INTO [Role] VALUES('Designer');
INSERT INTO [Role] VALUES('Manager');

SELECT * FROM [Role];

ALTER TABLE [User]
DROP COLUMN UserAge, UserGender;

ALTER TABLE [User]
ADD [Password] VARCHAR(MAX)
DEFAULT 123456
WITH VALUES,
RoleId INT,
FOREIGN KEY (RoleId) REFERENCES [Role] (RoleId) ON UPDATE NO ACTION ON DELETE NO ACTION

UPDATE [User]
SET RoleId = 4
WHERE UserId = 2;

ALTER TABLE [User]
ADD IsActive bit
DEFAULT 1
WITH VALUES;

ALTER TABLE [User]
ADD RoleName varchar(50)
DEFAULT 'Developer'
WITH VALUES;

INSERT INTO [User](UserName, Password) VALUES('dev', 212121);

UPDATE [User]
SET RoleName = 'dev'
WHERE UserId = 4;

SELECT * FROM [User];

