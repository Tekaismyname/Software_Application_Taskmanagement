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
CREATE TABLE Tasks (
    TaskID INT NOT NULL,
    SprintID INT NOT NULL,
    ProjectID INT NOT NULL,
    TaskName NVARCHAR(MAX) NOT NULL,
    Description NVARCHAR(MAX),
    StartDate DATE,
    DueDate DATE,
    Status NVARCHAR(50),

    PRIMARY KEY (TaskID, SprintID, ProjectID),
    FOREIGN KEY (SprintID, ProjectID) REFERENCES Sprints(SprintID, ProjectID)
);
CREATE TABLE TaskMembers (
    TaskID INT NOT NULL,
    SprintID INT NOT NULL,
    ProjectID INT NOT NULL,
    UserID INT NOT NULL,
    PRIMARY KEY (TaskID, SprintID, ProjectID, UserID),
    FOREIGN KEY (TaskID, SprintID, ProjectID) REFERENCES Tasks(TaskID, SprintID, ProjectID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

ALTER TABLE Tasks
ADD CONSTRAINT FK_Tasks_Sprint_Project
FOREIGN KEY (SprintID, ProjectID)
REFERENCES Sprints(SprintID, ProjectID);
exec sp_pkeys 'Sprints'
EXEC sp_fkeys 'Sprints';

USE ProjectManagement
Alter table Sprints
ADD Status NVARCHAR(50);

select * from ProjectMembers;
select * from Projects;
select * from Sprints;
select * from SprintMembers;
select * from Users;
select * from Tasks;
select * from WorkingStatus;
insert into SprintMembers values
delete from Sprints where ProjectID = '3'
delete from SprintMembers where ProjectID is null
UPDATE SprintMembers
SET ProjectID = (SELECT ProjectID FROM Sprints WHERE Sprints.SprintID = SprintMembers.SprintID)
WHERE ProjectID IS NULL

delete from Projects where ProjectID = '5';

CREATE TABLE Project (
    ProjectID INT PRIMARY KEY,
    ProjectName NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX),
    Status NVARCHAR(30), -- "Đang thực hiện", "Đã xong"
    Revenue DECIMAL(18,2),
    StartDate DATE,
    DueDate DATE
);
drop table Projects;
exec sp_rename 'Project', 'Projects';
EXEC sp_fkeys 'Projects';
ALTER TABLE Sprints add CONSTRAINT FK_Sprints_Projects FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID);
sp_help Projects;

CREATE TABLE Sprint (
    SprintID INT PRIMARY KEY,
    ProjectID INT FOREIGN KEY REFERENCES Projects(ProjectID),
    SprintName NVARCHAR(100),
    Description NVARCHAR(MAX),
	Status NVARCHAR(30),
    StartDate DATE,
    EndDate DATE
);

drop table SprintMembers;
CREATE TABLE SprintMembers (
    SprintID INT NOT NULL,
    ProjectID INT NOT NULL,
    UserID INT NOT NULL,
    PRIMARY KEY (SprintID, ProjectID, UserID),
    FOREIGN KEY (SprintID, ProjectID) REFERENCES Sprints(SprintID, ProjectID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);
-- Xóa khóa chính cũ nếu có
ALTER TABLE Sprints
DROP CONSTRAINT IF EXISTS PK_Sprints;

-- Tạo khóa chính kép (composite key)
ALTER TABLE Sprints
ADD CONSTRAINT PK_Sprints PRIMARY KEY (SprintID, ProjectID);


INSERT INTO Sprint(SprintID, SprintName, Description, StartDate, EndDate, Status, ProjectID)
SELECT SprintID, SprintName, Description, StartDate, EndDate, Status, ProjectID 
FROM Sprints;

ALTER TABLE Sprints
ADD CONSTRAINT PK_Sprints PRIMARY KEY (ProjectID, SprintID);
DROP CONSTRAINT PK__Sprint__29F16AE0E3F2AD07

exec sp_rename 'Sprint', 'Sprints';
EXEC sp_fkeys 'Projects';
ALTER TABLE SprintMembers
add constraint PK_SprintMembers_ProjectID Primary key (ProjectID)
add ProjectID int;

UPDATE SM
SET ProjectID = S.ProjectID
FROM SprintMembers SM
JOIN Sprints S ON SM.SprintID = S.SprintID;

ALTER TABLE SprintMembers
ADD CONSTRAINT FK_SprintMembers_Sprints
FOREIGN KEY (ProjectID, SprintID)
REFERENCES Sprints(ProjectID, SprintID);


drop constraint FK_SprintMembers_Sprint
FOREIGN KEY (SprintID) REFERENCES Sprints(SprintID);
ALTER TABLE Sprints add CONSTRAINT FK_Sprints_Projects FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID);
sp_help Projects;

ALTER TABLE Projects ADD DepartmentID INT;
ALTER TABLE Projects
ADD CONSTRAINT FK_Projects_Departments
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID);
UPDATE Projects SET DepartmentID = 1 WHERE ProjectID = 2;
UPDATE Projects SET DepartmentID = 1 WHERE ProjectID = 1;
UPDATE Projects SET DepartmentID = 2 WHERE ProjectID = 3;
UPDATE Projects SET DepartmentID = 1 WHERE ProjectID = 4;

Update Sprints set Status = 'Đang thuc hien' where SprintID = 1;

ALTER TABLE ProjectMembers add CONSTRAINT FK_ProjectMembers_Projects FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID);

-- Tạo danh sách ngày
WITH DateRange AS (
    SELECT CAST('2025-06-11' AS DATE) AS WorkDate
    UNION ALL
    SELECT DATEADD(DAY, 1, WorkDate)
    FROM DateRange
    WHERE WorkDate < '2025-12-30'
),
-- Lọc ra ngày làm việc (thứ 2 đến thứ 7)
WorkingDays AS (
    SELECT WorkDate
    FROM DateRange
    WHERE DATENAME(WEEKDAY, WorkDate) NOT IN ('Sunday')
),
-- Kết hợp user và ngày làm việc
UserDates AS (
    SELECT 
        U.UserID,
        D.WorkDate
    FROM Users U
    CROSS JOIN WorkingDays D
),
-- Gán trạng thái:
--  Nếu UserID nằm trong danh sách cố định => On-site
--  Ngược lại => Random On-site / Remote
FinalInsertData AS (
    SELECT 
        UD.UserID,
        UD.WorkDate,
        CASE 
            WHEN UD.UserID IN (1, 2, 3, 4) THEN 'On-site'
            ELSE 
                CASE 
                    WHEN ABS(CHECKSUM(NEWID())) % 2 = 0 THEN 'On-site'
                    ELSE 'Remote'
                END
        END AS Status
    FROM UserDates UD
)

-- Chèn vào bảng WorkingStatus
INSERT INTO WorkingStatus (UserID, WorkDate, Status)
SELECT UserID, WorkDate, Status
FROM FinalInsertData
OPTION (MAXRECURSION 0);

delete from SprintMembers where SprintID = '1' and UserID = '1'

SELECT * FROM Projects WHERE ProjectID =  1
