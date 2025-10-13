-- Create Department table
CREATE TABLE Department (
    Id VARCHAR(50) PRIMARY KEY,
    Name VARCHAR(100) NOT NULL
);

-- Create Employee table
CREATE TABLE Employee (
    Id VARCHAR(50) PRIMARY KEY,
    EmployeeNumber VARCHAR(20) NOT NULL,
    FirstName VARCHAR(100) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    Salary DECIMAL(18,2) NOT NULL,
    DepartmentId VARCHAR(50),
    FOREIGN KEY (DepartmentId) REFERENCES Department(Id)
);

-- Insert Departments
INSERT INTO Department (Id, Name) VALUES 
('D001', 'Human Resources'),
('D002', 'Engineering'),
('D003', 'Finance');

-- Insert Employees
INSERT INTO Employee (Id, EmployeeNumber, FirstName, LastName, Salary, DepartmentId) VALUES 
('E001', 'EMP1001', 'Alice', 'Smith', 65000, 'D001'),
('E002', 'EMP1002', 'Bob', 'Johnson', 85000, 'D002'),
('E003', 'EMP1003', 'Carol', 'Taylor', 70000, 'D003'),
('E004', 'EMP1004', 'David', 'Brown', 72000, 'D002'),
('E005', 'EMP1005', 'Juan', 'Smith', 65000, 'D001'),
('E006', 'EMP1006', 'Pedro', 'Johnson', 85000, 'D002'),
('E007', 'EMP1007', 'Mark', 'Taylor', 70000, 'D003'),
('E008', 'EMP1008', 'John', 'Brown', 72000, 'D002');
