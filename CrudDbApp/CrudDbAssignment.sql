USE School;
GO;

ALTER PROC [dbo].[spSearch](
	@Search VARCHAR(50)
)
AS
BEGIN
	SELECT  
		s.StudentId,
		s.StudentFname,
		s.StudentLname,
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
	WHERE StudentFname LIKE '%' + @Search + '%'
END
GO;

EXEC spSearch 'S'
GO;

SELECT * FROM Student;
GO;

CREATE PROC [dbo].[spInsertUpdateStudent](
	@StudentId BIGINT,
	@StudentFname VARCHAR(50),
	@StudentLname VARCHAR(50),
	@StudentEmail VARCHAR(50),
	@StudentPhoneNo VARCHAR(50),
	@StudentDob VARCHAR(50),
	@TeacherId VARCHAR(50),
	@LocId VARCHAR(50),
	@Result BIGINT OUTPUT
)
AS
BEGIN
	SET @Result = CAST(0 AS BIGINT)
	IF(@StudentId = 0)
		BEGIN 
			INSERT INTO Student(StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId, LocId)
			VALUES(@StudentFname, @StudentLname, @StudentEmail, @StudentPhoneNo, @StudentDob, @TeacherId, @LocId )

			SELECT @Result = SCOPE_IDENTITY()
		END
	ELSE
		BEGIN
			UPDATE Student SET StudentFname = @StudentFname, StudentLname = @StudentLname, StudentEmail = @StudentEmail, 
				StudentPhoneNo = @StudentPhoneNo, TeacherId = @TeacherId, LocId = @LocId 
			WHERE StudentId = @StudentId

			SET @Result = @StudentId
		END
END
GO;

DECLARE @Result BIGINT
EXEC [dbo].[spInsertUpdateStudent] 40, 'Elena', 'Gilbert', 'nina@tvd.com', '123.456.3131','1995-02-21', 3, 4, @Result OUT
SELECT @Result
GO;


--StudentPagination
ALTER PROCEDURE [dbo].[spPagination]
       @PageNumber INT,
       @pageSize INT,
       @totalCount INT OUT
AS
BEGIN
       SET NOCOUNT ON;

       SELECT StudentId, StudentFname, StudentLname, StudentEmail, StudentPhoneNo, StudentDob, TeacherId, LocId
	   FROM Student
       ORDER BY StudentId
       OFFSET @PageNumber ROWS FETCH NEXT @pageSize ROWS ONLY

       SELECT @totalCount = COUNT(StudentId) FROM Student
END
GO;

DECLARE @Result INT
EXEC [dbo].[spPagination] 12, 3, @Result OUT
SELECT @Result
GO; 


--StudentPagination
ALTER PROCEDURE [dbo].[spPagination2](
	@PageNumber INT,
	@PageSize INT
)
AS 
BEGIN
	SELECT *
	FROM Student
	ORDER BY StudentId
	OFFSET (@PageNumber - 1)*@PageSize  ROWS
	FETCH NEXT @PageSize ROWS ONLY
END
GO;

EXEC [dbo].[spPagination2] 11,3;
GO;   

