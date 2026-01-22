USE ms_dynamicsDB;
CREATE TABLE Students(
StudentId INT PRIMARY KEY,
Email VARCHAR(100) UNIQUE,
Age INT CHECK(Age>=18),
CourseId INT
);
--DML
INSERT INTO Students VALUES (1, 'rahul@gmail.com', 20, 101);
INSERT INTO Students VALUES (2, 'neha@gmail.com', 22, 102);
INSERT INTO Students VALUES (3, 'amit@gmail.com', 19, 101);
SELECT * FROM Students;
INSERT INTO Students VALUES (4, 'divya@gmail.com', 21, 101);
--Agregate functions
--Sum,Average,length etc
--total no of students
SELECT COUNT(*) AS TotalStudents FROM Students;
--Average marks or age
SELECT AVG(Age) AS AverageAge FROM Students;
--scalar function 
SELECT StudentId,LEN(Email) as EmailLength,
GETDATE() AS currentDate
FROM Students
SELECT * FROM Students;

--Grouping
SELECT courseId, COUNT(*) AS StudentCount
FROM Students
GROUP BY CourseId;
SELECT COUNT(*) AS TotalStudents FROM Students;

--Transactions  commit,rollback & savepoint
BEGIN TRANSACTION;
	UPDATE Students
	SET AGE = AGE+1
	WHERE CourseId = 101;
ROLLBACK;  --Above changes are not reflected hence rollbacked to previous consistent state
--No change due to rollback
BEGIN TRANSACTION;
	UPDATE Students
	SET AGE = AGE+1
	WHERE CourseId = 101;
COMMIT;

--savepoint
BEGIN TRANSACTION;
UPDATE Students SET Age=25 WHERE StudentId=2;
SAVE TRANSACTION S1; --All the changes will be saved till this point hence if we rollback we can to this point in transaction
--Above operation are not permanent and its state is saved as s1
UPDATE Students SET Age=30 WHERE StudentId=1;
ROLLBACK TRANSACTION S1;  --Above update is rollbacked and previous  state is s1 is achieved
COMMIT;

--Access control Grant and Revoke
GRANT SELECT , INSERT ON Students to User1; --user 1 is allowed to perform these operations
REVOKE INSERT ON Students FROM User1; --revoking user1 to perform insert operations

--DDL -Alter
ALTER table Students
ADD Phone VARCHAR(50);
SELECT * FROM Students; 
--creating a function that displays/run select*from table
CREATE FUNCTION dbo.fn_DisplayStudent_Table()
returns TABLE 
AS 
RETURN
(
SELECT StudentId, Email,Age,CourseId FROM Students
);

SELECT * FROM dbo.fn_DisplayStudent_Table();
CREATE FUNCTION dbo.GET_StudentByCourseId( @CourseId INT)
returns TABLE
AS
RETURN
(
	SELECT StudentId,Email,Age FROM Students
	WHERE CourseId=@CourseId
);
SELECT * FROM dbo.fn_DisplayStudent_Table();
SELECT * FROM dbo.GET_STUDENTByCourseId(101);