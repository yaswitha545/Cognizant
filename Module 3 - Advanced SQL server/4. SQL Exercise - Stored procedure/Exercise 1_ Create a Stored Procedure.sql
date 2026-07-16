-- Create Database
CREATE DATABASE EmployeeDB;
USE EmployeeDB;


-- Departments Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


-- Employees Table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY AUTO_INCREMENT,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10,2),
    JoinDate DATE,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);


-- Insert Departments
INSERT INTO Departments 
(DepartmentID, DepartmentName)
VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');


-- Insert Employees
INSERT INTO Employees
(EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate)
VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');



-- ===================================
-- Exercise 1
-- Stored Procedure: Get Employees
-- By DepartmentID
-- ===================================

DELIMITER //

CREATE PROCEDURE GetEmployeesByDepartment(
    IN deptID INT
)
BEGIN

    SELECT 
        EmployeeID,
        FirstName,
        LastName,
        Salary,
        JoinDate
    FROM Employees
    WHERE DepartmentID = deptID;

END //

DELIMITER ;


-- Execute Procedure
CALL GetEmployeesByDepartment(3);



-- ===================================
-- Stored Procedure: Insert Employee
-- ===================================

DELIMITER //

CREATE PROCEDURE sp_InsertEmployee(
    IN p_FirstName VARCHAR(50),
    IN p_LastName VARCHAR(50),
    IN p_DepartmentID INT,
    IN p_Salary DECIMAL(10,2),
    IN p_JoinDate DATE
)

BEGIN

INSERT INTO Employees
(
FirstName,
LastName,
DepartmentID,
Salary,
JoinDate
)

VALUES
(
p_FirstName,
p_LastName,
p_DepartmentID,
p_Salary,
p_JoinDate
);

END //

DELIMITER ;



-- Test Insert Procedure
CALL sp_InsertEmployee(
    'Alex',
    'Brown',
    3,
    8000.00,
    '2022-05-10'
);


-- Check Data
SELECT * FROM Employees;
