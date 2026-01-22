CREATE DATABASE ms_dynamicsDB;
USE ms_dynamicsDB;
CREATE TABLE FPO1(
FPOID INT IDENTITY(1,1) PRIMARY KEY,
FPOName VARCHAR(100) NOT NULL,
myState VARCHAR(50) NOT NULL,
MemberCount INT CHECK (MemberCount>0),
Registrations DATE NOT NULL);
INSERT INTO FPO1(FPOName,myState,MemberCount,Registrations)
Values
('Greenharvest FPO', 'Maharastra', 250, '2025-06-15'),
('Agro unity FPO', 'Karnataka', 180, '2023-09-10');
SELECT * FROM FPO1;

SELECT * FROM FPO1
WHERE MemberCount > 200;
SELECT FPOName, myState FROM FPO1
WHERE MemberCount < 200;
UPDATE FPO1
SET MemberCount = 300
WHERE FPOName = 'Greenharvest FPO';
SELECT * FROM FPO1;
DELETE FROM FPO1
WHERE FPOName = 'Agro unity FPO';
DROP TABLE FPO1;