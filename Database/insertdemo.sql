-- Thêm phòng ban
INSERT INTO Departments (DepartmentName) VALUES
(N'Coding'), (N'Marketing');

-- Thêm người dùng
INSERT INTO Users (FullName, Email, Major, Role, DepartmentID)
VALUES
(N'Huỳnh Công Minh', 'c@gmail.com', N'Lập trình', 'User', 1);

(N'Nguyễn Văn A', 'a@gmail.com', N'Lập trình', 'User', 1),
(N'Trần Thị B', 'b@gmail.com', N'Marketing', 'User', 2),
(N'Huỳnh Công Minh', 'c@gmail.com', N'Lập trình', 'User', 1),
(N'Admin', 'admin@gmail.com', N'Quản trị dự án', 'Admin', 1);

-- Thêm dự án
INSERT INTO Projects (ProjectName, Description, Status, Revenue, CreatedDate, StartDate, DueDate)
VALUES
(N'Dự án truyền thông sản phẩm', N'Tiếp thị sữa trên cao tốc', N'Đang thực hiện', 800000, '2025-07-01', '2025-07-09', '2025-10-31');

(N'Dự án Website A', N'Thiết kế và triển khai web', N'Đang thực hiện', 100000, '2025-06-01', '2025-06-05', '2025-07-05'),
(N'Dự án Website B', N'Cấu hình hạ tầng CNTT tòa nhà Bitexco', N'Đang thực hiện', 500000, '2025-07-01', '2025-07-08', '2025-10-29');


-- Gán người dùng vào dự án (1, 1), (1, 2), 
INSERT INTO ProjectMembers (ProjectID, UserID)
VALUES (3, 2);

-- Thêm Sprint
INSERT INTO Sprints (ProjectID, SprintName, Description, StartDate, EndDate)
VALUES (1, N'Sprint 1', N'Phân tích và thiết kế', '2025-06-05', '2025-06-12');

-- Gán người vào Sprint
INSERT INTO SprintMembers (SprintID, UserID)
VALUES (1, 1), (1, 2);

-- Trạng thái làm việc
INSERT INTO WorkingStatus (UserID, WorkDate, Status)
VALUES (1, '2025-06-10', 'On-site'),
       (2, '2025-06-10', 'Remote');

SELECT IDENT_CURRENT('Users');
DBCC CHECKIDENT ('Users', RESEED, 3);--Dat lai ID ve 3

--alter table Projects add DepartmentID int;

SELECT ProjectID, ProjectName, DepartmentID 
FROM Projects
WHERE DepartmentID IS NULL;

UPDATE Projects
SET DepartmentID = (
    SELECT TOP 1 DepartmentID 
    FROM Departments 
    ORDER BY NEWID()
)
WHERE DepartmentID IS NULL;--Tu dong gan ID

select * from Departments;