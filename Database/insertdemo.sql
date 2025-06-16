-- Thêm phòng ban
INSERT INTO Departments (DepartmentName) VALUES
(N'Coding'), (N'Marketing');

-- Thêm người dùng
INSERT INTO Users (FullName, Email, Major, Role, DepartmentID)
VALUES
(N'Nguyễn Văn A', 'a@gmail.com', N'Lập trình', 'User', 1),
(N'Trần Thị B', 'b@gmail.com', N'Marketing', 'User', 2),
(N'Admin', 'admin@gmail.com', N'Quản trị dự án', 'Admin', 1);

-- Thêm dự án
INSERT INTO Projects (ProjectName, Description, Status, Revenue, CreatedDate, StartDate, DueDate)
VALUES
(N'Dự án Website A', N'Thiết kế và triển khai web', N'Đang thực hiện', 10000000, '2025-06-01', '2025-06-05', '2025-07-05');

-- Gán người dùng vào dự án
INSERT INTO ProjectMembers (ProjectID, UserID)
VALUES (1, 1), (1, 2);

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
