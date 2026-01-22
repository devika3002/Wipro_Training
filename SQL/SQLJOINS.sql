use ms_dynamicsDB;
-- Courses( Master table )
-- Students ( transaction Table)
-- Trainers( Self Join use cases)

CREATE TABLE MyCourses (
    CourseId INT PRIMARY KEY,
    CourseName VARCHAR(100)
);

CREATE TABLE My_Students (
    StudentId INT PRIMARY KEY,
    StudentName VARCHAR(50),
    CourseId INT
);
CREATE TABLE Trainers (
    TrainerId INT PRIMARY KEY,
    TrainerName VARCHAR(50),
    ManagerId INT
);
INSERT INTO MyCourses VALUES
(01, 'FULLSTACK'),
(02, 'CYBERSECURITY'),
(03, 'DIGITALMARKETING'),
(04, 'UI/UX');


INSERT INTO My_Students VALUES
(101, 'RAHUL', 01),
(102, 'NEHA', 02),
(103, 'SATYA', 03),
(104, 'DIVYA', 04);



INSERT INTO Trainers VALUES
(1, 'ARJUN', NULL),
(2, 'RAVI', 1),
(3, 'SNEHA', 1),
(4, 'KIRAN', 2);

SELECT * FROM MyCourses,My_Students,Trainers;
SELECT * FROM MyCourses;
SELECT * FROM My_Students;
SELECT * FROM Trainers;

--Types of joins
--Inner Join - it returns common value in both the table
SELECT s.StudentName,s.StudentId,c.CourseName,c.CourseId
FROM My_Students s
Inner Join MyCourses c
ON s.CourseID = c.CourseID;

--Left join : will return all left table record+matched right records
SELECT s.StudentName,s.StudentId,c.CourseNAme,c.CourseId
FROM My_Students s
LEFT JOIN MyCourses c
ON s.CourseId=c.CourseId;

--Right join : All right record+matching record
--It will display all courses if there is no enrollede student
SELECT s.StudentName,s.StudentId,c.CourseName,c.CourseId
FROM My_Students s
RIGHT JOIN MyCourses c
ON s.CourseId=c.CourseId;

--full outer join
--it returns all the records from both tables
SELECT s.StudentName,s.StudentId,c.CourseName,c.CourseId
FROM My_Students s
FULL OUTER JOIN MyCourses c
ON s.CourseId=c.CourseId;

--self join : Trainer -manager-hierarchy
--university -HOD-Faculty -hierarchy

SELECT 
    t1.TrainerName AS Trainers,
    t2.TrainerName AS Manager
    FROM Trainers t1
    LEFT JOIN Trainers t2
    ON t1.ManagerId=t2.TrainerId;
--table joins to itself

--CROSS Join : It returns cartesian product
--All possible student and course combination
--used in testing and simulations
SELECT s.StudentName, c.CourseName
FROM My_Students s
CROSS JOIN MyCourses c;

--Union : Combine result and remove duplicate
--list of all people in the system
SELECT StudentName from My_Students
UNION
SELECT TrainerName FROM Trainers;

--INTERSECT: returning common record
SELECT StudentName from My_Students
INTERSECT
SELECT TrainerName FROM Trainers;

--THERE IS NO STUDENT WHO IS ALSO A TRAINER

--MINUS: people who are students but not trainers
SELECT StudentName from My_Students
EXCEPT
SELECT TrainerName FROM Trainers;