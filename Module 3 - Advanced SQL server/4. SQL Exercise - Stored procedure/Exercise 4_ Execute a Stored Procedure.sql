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
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');


-- Insert Employees
INSERT INTO Employees VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');


-- Create Stored Procedure

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


-- Execute Stored Procedure

CALL GetEmployeesByDepartment(3);
