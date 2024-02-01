CREATE TABLE Course (
    CourseID NVARCHAR(50),
    CourseName NVARCHAR(255) NOT NULL,
    CreditHour INT NOT NULL,
    DepartmentID VARCHAR(50),
    PRIMARY KEY (CourseID),
    CONSTRAINT UQ_Course_Department UNIQUE (CourseID, DepartmentID),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DeptID)
);
CREATE TABLE Instructors (

 Username NVARCHAR(50) NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Sex NVARCHAR(10) NOT NULL,
    DateOfBirth DATE,
    DeptID VARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
   
    Password NVARCHAR(50) NOT NULL,
    -- Add other columns as needed
    CONSTRAINT FK_DeptID FOREIGN KEY (DeptID) REFERENCES Departments(DeptID)
);

ALTER TABLE Instructors
ADD ProfileImage VARBINARY(MAX);

CREATE TABLE Students (
    Username NVARCHAR(50) PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Sex NVARCHAR(10) NOT NULL,
    DateOfBirth DATE,
    DepartmentID VARCHAR(50) NOT NULL,
    Year INT,
    Email NVARCHAR(100),
    Password NVARCHAR(50) NOT NULL,
    ProfileImage VARBINARY(MAX),
    CONSTRAINT FK_Student_Department FOREIGN KEY (DepartmentID) REFERENCES Departments(DeptID)
);

select *from Users

select *from Students