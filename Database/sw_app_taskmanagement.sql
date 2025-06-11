create database sw_app_taskmanagement;

use sw_app_taskmanagement;


-- 1. Người dùng
CREATE TABLE Users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    password_hash VARCHAR(255) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 2. Dự án
CREATE TABLE Projects (
    project_id INT AUTO_INCREMENT PRIMARY KEY,
    project_name VARCHAR(100) NOT NULL,
    project_description TEXT,
    created_by INT NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (created_by) REFERENCES Users(user_id)
);

-- 3. Vai trò và thành viên dự án
CREATE TABLE ProjectRoles (
    role_id INT AUTO_INCREMENT PRIMARY KEY,
    role_name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE User_Project (
    id INT AUTO_INCREMENT PRIMARY KEY,
    user_id INT NOT NULL,
    project_id INT NOT NULL,
    role_id INT NOT NULL,
    status ENUM('accepted', 'pending') DEFAULT 'accepted',
    FOREIGN KEY (user_id) REFERENCES Users(user_id),
    FOREIGN KEY (project_id) REFERENCES Projects(project_id),
    FOREIGN KEY (role_id) REFERENCES ProjectRoles(role_id),
    UNIQUE (user_id, project_id)
);

-- 4. Sprint
CREATE TABLE Sprints (
    sprint_id INT AUTO_INCREMENT PRIMARY KEY,
    project_id INT NOT NULL,
    name VARCHAR(100) NOT NULL,
    start_date DATE,
    end_date DATE,
    FOREIGN KEY (project_id) REFERENCES Projects(project_id)
);

-- 5. Sprint Backlog (gộp cả Product và Sprint backlog)
CREATE TABLE Sprint_Backlog (
    sprint_backlog_id INT AUTO_INCREMENT PRIMARY KEY,
    project_id INT NOT NULL,
    sprint_id INT DEFAULT NULL,
    title VARCHAR(255) NOT NULL,
    FOREIGN KEY (project_id) REFERENCES Projects(project_id),
    FOREIGN KEY (sprint_id) REFERENCES Sprints(sprint_id)
);

-- 6. Task Breakdown
CREATE TABLE Tasks (
    task_id INT AUTO_INCREMENT PRIMARY KEY,
    sprint_backlog_id INT NOT NULL,
    task_title VARCHAR(200) NOT NULL,
    task_status ENUM('Not Started', 'In Progress', 'Review', 'Done') DEFAULT 'Not Started',
    priority ENUM('Low', 'Medium', 'High') DEFAULT 'Medium',
    assigned_to INT,
    FOREIGN KEY (sprint_backlog_id) REFERENCES Sprint_Backlog(sprint_backlog_id),
    FOREIGN KEY (assigned_to) REFERENCES Users(user_id)
);



-- drop database sw_app_taskmanagement;
