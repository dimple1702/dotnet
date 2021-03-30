USE School;
GO;


CREATE PROC spSimpleProcedure
AS
BEGIN
	SELECT 
		s.StudentId,
		s.StudentFname + ' ' + s.StudentLname AS StudentName,
		s.StudentEmail,
		t.TeacherFname + ' ' + t.TeacherLname AS TeacherName,
		t.TeacherEmail,
		d.DeptName,
		l.[Address] + ', ' + l.City + ', ' + c.CountryName AS [Address]
	FROM Student s
	INNER JOIN Teacher t ON s.TeacherId = t.TeacherId
	INNER JOIN Department d ON t.DeptId = d.DeptId
	INNER JOIN [Location] l ON t.LocId = l.LocId
	INNER JOIN Country c ON l.CountryId = c.CountryId
END
GO;

EXEC spSimpleProcedure;

--stored procedure for Pagination
CREATE PROC spPagination(
	@PageNumber INT,
	@PageSize INT
)
AS 
BEGIN
	SELECT s.StudentId, 
		s.StudentFname + ' ' + s.StudentLname AS StudentName, 
		s.StudentEmail, 
		t.TeacherFname + ' ' + t.TeacherLname as TeacherName
	FROM STUDENT s
	INNER JOIN Teacher t
	ON t.TeacherId = s.TeacherId
	ORDER BY s.StudentId
	OFFSET (@PageNumber - 1)*@PageSize  ROWS
	FETCH NEXT @PageSize ROWS ONLY
END
GO;

EXEC spPagination 19,3;
GO

-- Split the names
CREATE FUNCTION SplitFromComma(	
	@Name varchar(50),
	@Comma varchar(10)
)
RETURNS @SeparatedNames TABLE ([SeparatedName] varchar(50))
AS
BEGIN
	DECLARE @SubString varchar(50)
	WHILE (CHARINDEX(@Comma, @Name) <> 0)	-- CHARINDEX(substring, string)
	BEGIN
		SET @SubString = SUBSTRING(@Name, 1, CHARINDEX(@Comma, @Name) -1)	--SUBSTRING(string, start, length)
		SET @Name = STUFF(@Name, 1, CHARINDEX(@Comma, @Name), '')	-- STUFF(string, start, length, new_string)
		INSERT INTO @SeparatedNames 
		SELECT @SubString
	END
	INSERT INTO @SeparatedNames 
	SELECT @SubString
	RETURN
END
GO;

-- built-in function of sql
SELECT * FROM  STRING_SPLIT ('Dimple,Elena,Katherine,Caroline,Bonny,Hayley,Klaus,Damon,Stefan', ',')

SELECT * FROM SplitFromComma('Dimple,Elena,Katherine,Caroline,Bonny',','); 
GO;

--creating a view (a saved select query)
CREATE VIEW StudentTeacher
AS
SELECT s.StudentId,
	s.StudentFname + ' ' + s.StudentLname AS StudentName,
	s.StudentEmail,
	t.TeacherFname + ' ' + t.TeacherLname as TeacherName,
	t.TeacherEmail
FROM STUDENT s
INNER JOIN Teacher t
ON t.TeacherId = s.TeacherId
GO;

--using view
SELECT top 6 * FROM StudentTeacher;
GO;

--temp table
ALTER PROC TempTable
AS
BEGIN
CREATE TABLE #Student
(
	Fname varchar(50) not null,
	Lname varchar(50) not null,
	Email varchar(50) not null,
)
INSERT INTO Student
SELECT StudentFname,StudentLname, StudentEmail from Student where StudentId = 1;
SELECT * from Student;
END
GO;



