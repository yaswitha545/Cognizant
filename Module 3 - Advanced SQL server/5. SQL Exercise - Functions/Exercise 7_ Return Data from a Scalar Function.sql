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
(3, 'IT');


-- Insert Employees
INSERT INTO Employees VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-01');



-- ====================================
-- Exercise 7:
-- Function Calculate Annual Salary
-- ====================================

DELIMITER //

CREATE FUNCTION fn_CalculateAnnualSalary(
    empID INT
)
RETURNS DECIMAL(10,2)
DETERMINISTIC

BEGIN

    DECLARE AnnualSalary DECIMAL(10,2);


    SELECT Salary * 12
    INTO AnnualSalary
    FROM Employees
    WHERE EmployeeID = empID;


    RETURN AnnualSalary;

END //

DELIMITER ;



-- Execute function for EmployeeID = 1

SELECT fn_CalculateAnnualSalary(1) 
AS AnnualSalary;
