-- Create Database
CREATE DATABASE EmployeeCountDB;
USE EmployeeCountDB;


-- Departments Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


-- Employees Table

CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);


-- Insert Departments

INSERT INTO Departments VALUES
(1,'HR'),
(2,'Finance'),
(3,'IT'),
(4,'Marketing');


-- Insert Employees

INSERT INTO Employees VALUES
(1,'John','Doe',1,5000,'2020-01-15'),
(2,'Jane','Smith',2,6000,'2019-03-22'),
(3,'Michael','Johnson',3,7000,'2018-07-30'),
(4,'Emily','Davis',4,5500,'2021-11-05');



-- Create Stored Procedure to count employees

DELIMITER //

CREATE PROCEDURE CountEmployeesByDepartment(
    IN deptID INT
)

BEGIN

SELECT 
    COUNT(*) AS TotalEmployees
FROM Employees
WHERE DepartmentID = deptID;

END //

DELIMITER ;



-- Execute Procedure

CALL CountEmployeesByDepartment(3);
