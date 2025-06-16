-- 1. Phòng ban
SELECT * FROM Departments;

-- 2. Người dùng
SELECT * FROM Users;

-- 3. Dự án
SELECT * FROM Projects;

-- 4. Thành viên tham gia dự án
SELECT * FROM ProjectMembers;

-- 5. Sprint
SELECT * FROM Sprints;

-- 6. Thành viên tham gia sprint
SELECT * FROM SprintMembers;

-- 7. Trạng thái làm việc theo ngày
SELECT * FROM WorkingStatus;

SELECT 
    P.ProjectName,
    U.FullName,
    U.Email
FROM ProjectMembers PM
JOIN Projects P ON PM.ProjectID = P.ProjectID
JOIN Users U ON PM.UserID = U.UserID;

SELECT 
    S.SprintName,
    U.FullName,
    S.StartDate,
    S.EndDate
FROM SprintMembers SM
JOIN Sprints S ON SM.SprintID = S.SprintID
JOIN Users U ON SM.UserID = U.UserID;

 
