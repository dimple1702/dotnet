USE Practice;
GO  -- 'GO' keyword splits the statement into separate batches and is added to remove the error 'must be the only statement in the batch.'

-- Creating a stored procedure (SP)
CREATE PROC spGetPersons
AS
BEGIN  
	SELECT ID, [Name], City, Age, Email FROM Person;
END
GO

-- executing Stored Procedure - 3 ways
spGetPersons
EXEC spGetPersons
EXECUTE spGetPersons
 -- 4th way to execute: using GUI right click on sp and click execute stored procedure
GO

-- creating stored procedure with parameter
CREATE PROC spGetPersonsByCity
@City varchar(50)
AS
BEGIN
	SELECT ID, [Name], City, Age, Email FROM Person WHERE City = @City;
END
GO

-- executing sp with parameters
spGetPersonsByCity @City = 'Mystic Falls'
GO

-- to get text of SP - 2 ways: one by GUI and other:
sp_helptext spGetPersons  --system SP have prefix 'sp_' so MS doesnt recommend us to use this prefix for user defined SP
GO

-- changing implementation of SP
ALTER PROCEDURE spGetPersons
AS
BEGIN  
	SELECT ID, [Name], City, Age, Email 
	FROM Person
	ORDER BY [Name];
END

EXEC spGetPersons
GO

-- Encrypting the SP
ALTER PROC spGetPersonsByCity(
	@City varchar(50)  
)	
WITH ENCRYPTION	 -- for encrypting the procedure
AS  
BEGIN  
 SELECT ID, [Name], City, Age, Email FROM Person WHERE City = @City;  
END  
GO

-- after executing it, you'll see a little lock in the icon of this SP in Object Explorer
-- now nobody is able to get the text of this SP using following command. It can be delted though
sp_helptext spGetPersonsByCity;
GO

-- SP with output parameters
CREATE PROC spGetPersonCountByGender(
	@Gender bit,
	@PersonCount int OUTPUT
)
AS
BEGIN
	SELECT @PersonCount = COUNT(*) 
	FROM Person
	WHERE Gender = @Gender
END
GO

-- executing the SP with output
DECLARE @PersonCount int 
EXECUTE spGetPersonCountByGender 0, @PersonCount OUTPUT  -- without output keyword, it will not fetch the result

IF(@PersonCount IS NULL)
	PRINT 'Total Person Count is Null'
ELSE
	PRINT 'Total Person Count is Null'
PRINT @PersonCount
GO

-- System defined SP
sp_help spGetPersonCountByGender  -- to get the info about the SP
GO

sp_helptext spGetPersonCountByGender  -- to get the text of SP
GO

sp_depends spGetPersonCountByGender  --to get the dependencies of the SP
GO

-- creating SP that return values(0 means sucess and non-zero means failure)
CREATE PROC spGetPersonCountByGenderReturnValue(
	@Gender bit
)
AS
BEGIN
 return (
	SELECT COUNT(*) 
	FROM Person
	WHERE Gender = @Gender
 )
END
GO

-- executing the SP with output
DECLARE @PersonCount int
EXECUTE @PersonCount = spGetPersonCountByGenderReturnValue 1
SELECT @PersonCount AS TotalPersonsOfSpecifiedGender;
GO











