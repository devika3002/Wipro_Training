Use ms_dynamicsDB;

CREATE TABLE Employees
(
    EmpId INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Salary INT NOT NULL,
    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
);

SELECT * FROM Employees;
CREATE PROCEDURE usp_AddEmployee
	@Name VARCHAR(50),
	@Salary INT,
	@EMPID INT OUTPUT
	AS
	BEGIN
		BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO Employees(Name,Salary)
			VALUES( @Name,@Salary)
			SET @EMPID=SCOPE_IDENTITY()

			COMMIT TRANSACTION
		END TRY
			BEGIN CATCH
			ROLLBACK TRANSACTION
			THROW
		END CATCH
	END
DECLARE @ID INT
EXECUTE usp_AddEmployee 'Divya',50000,@ID OUTPUT
SELECT @ID

--creating a Trigger


SELECT * FROM Employees;
--logging/Auditing

CREATE TABLE EmployeeSalaryAudit
--write only table
--this table will record all entries related to EMP salary for auditing
(
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    EmpId INT,
    OldSalary INT,
    NewSalary INT,
    ChangedOn DATETIME DEFAULT GETDATE()
);
SELECT * FROM EmployeeSalaryAudit;
--creating after update trigger

CREATE TRIGGER trg_AuditEmployeeSalary
ON EMPLOYEES
AFTER UPDATE
AS
BEGIN
	IF NOT UPDATE(salary)
	RETURN;
	INSERT INTO EmployeeSalaryAudit(EmpId,OldSalary,NewSalary)
	SELECT
		d.EmpId,
		d.salary AS OldSalary,
		i.salary AS NewSalary
		FROM deleted d
		INNER JOIN inserted i
		ON d.EmpId = i.EmpId;
END

--calling trigger  with data
--peerforming update operation that calls trigger indirectly and performs entry into audit table
UPDATE Employees
SET Salary=Salary+12000
WHERE EmpId=1;