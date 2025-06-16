-- 2. Tạo bảng Departments (không phụ thuộc bảng nào)
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(50) NOT NULL
);

-- 3. Tạo bảng Users (phụ thuộc Departments)
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    Major NVARCHAR(100),
    Role NVARCHAR(20), -- Admin, User
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID)
);

-- 4. Tạo bảng Projects (không có FK)
CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    ProjectName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Status NVARCHAR(30), -- "Đang thực hiện", "Đã xong"
    Revenue DECIMAL(18,2),
    CreatedDate DATE,
    StartDate DATE,
    DueDate DATE
);

-- 5. Tạo bảng ProjectMembers (phụ thuộc Projects, Users)
CREATE TABLE ProjectMembers (
    ProjectID INT FOREIGN KEY REFERENCES Projects(ProjectID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    PRIMARY KEY(ProjectID, UserID)
);

-- 6. Tạo bảng Sprints (phụ thuộc Projects)
CREATE TABLE Sprints (
    SprintID INT PRIMARY KEY IDENTITY(1,1),
    ProjectID INT FOREIGN KEY REFERENCES Projects(ProjectID),
    SprintName NVARCHAR(100),
    Description NVARCHAR(MAX),
    StartDate DATE,
    EndDate DATE
);

-- 7. Tạo bảng SprintMembers (phụ thuộc Sprints, Users)
CREATE TABLE SprintMembers (
    SprintID INT FOREIGN KEY REFERENCES Sprints(SprintID),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    PRIMARY KEY(SprintID, UserID)
);

-- 8. Tạo bảng WorkingStatus (phụ thuộc Users)
CREATE TABLE WorkingStatus (
    StatusID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT FOREIGN KEY REFERENCES Users(UserID),
    WorkDate DATE NOT NULL,
    Status NVARCHAR(20) NOT NULL -- 'On-site' hoặc 'Remote'
);
