use sw_app_taskmanagement;

-- Users
INSERT INTO Users (full_name, email, password_hash) VALUES
('John Doe', 'john1@example.com', 'hashed_password_1'),
('Jane Smith', 'jane1@example.com', 'hashed_password_2'),
('Mike Johnson', 'mike1@example.com', 'hashed_password_3'),
('Emily Davis', 'emily1@example.com', 'hashed_password_4'),
('Chris Evans', 'chris1@example.com', 'hashed_password_5');

-- Projects
INSERT INTO Projects (project_name, project_description, created_by) VALUES
('Quản lý công việc nhóm', 'Dự án quản lý công việc sử dụng WinForms', 1),
('CRM nội bộ', 'Quản lý khách hàng và giao việc nội bộ', 2),
('Website bán hàng', 'Quản lý sản phẩm, giỏ hàng, đơn hàng', 3),
('Ứng dụng đào tạo', 'Hệ thống đào tạo nội bộ công ty', 4),
('Hệ thống tuyển dụng', 'Quản lý ứng viên và phỏng vấn', 5);

-- ProjectRoles
INSERT INTO ProjectRoles (role_name) VALUES
('Admin'),
('Manager'),
('Developer'),
('Tester'),
('Viewer');

-- User_Project
INSERT INTO User_Project (user_id, project_id, role_id, status) VALUES
(1, 1, 1, 'accepted'),
(2, 1, 3, 'accepted'),
(3, 2, 2, 'pending'),
(4, 2, 3, 'accepted'),
(5, 3, 4, 'accepted');

-- Sprints
INSERT INTO Sprints (project_id, name, start_date, end_date) VALUES
(1, 'Sprint 1', '2025-06-01', '2025-06-10'),
(1, 'Sprint 2', '2025-06-11', '2025-06-20'),
(2, 'Sprint 1', '2025-06-05', '2025-06-15'),
(3, 'Sprint A', '2025-06-01', '2025-06-12'),
(4, 'Sprint 1', '2025-06-08', '2025-06-18');

-- Sprint_Backlog
INSERT INTO Sprint_Backlog (project_id, sprint_id, title) VALUES
(1, 1, 'Đăng nhập hệ thống'),
(1, 1, 'Quản lý user'),
(2, 3, 'Tạo dự án mới'),
(2, 3, 'Gán thành viên vào dự án'),
(3, 4, 'Thiết lập dashboard');

-- Tasks
INSERT INTO Tasks (sprint_backlog_id, task_title, task_status, priority, assigned_to) VALUES
(1, 'Tạo form đăng nhập', 'Not Started', 'Medium', 1),
(1, 'Xử lý xác thực backend', 'In Progress', 'High', 2),
(2, 'Tạo bảng Users', 'Review', 'Medium', 3),
(3, 'Tạo giao diện dự án', 'Done', 'Low', 4),
(4, 'Lập API thêm thành viên', 'In Progress', 'High', 5);

Select * from Users;
select * from Projects;
select * from ProjectRoles;
select * from User_Project;
select * from Sprints;
select * from Sprint_Backlog;
Select * from Tasks;
