# Software_Application_Taskmanagement
# ERD draw.io
https://drive.google.com/file/d/1B-d-nJHtFW3O8bW_0wCxp7J4zeaWJS5X/view?usp=sharing
# create_readme.py

readme_content = """# 🗂️ Task Management - WinForms App

Ứng dụng **Quản lý công việc** được xây dựng bằng công nghệ **C# WinForms** và **MySQL**, nhằm hỗ trợ các nhóm nhỏ quản lý tiến độ dự án theo mô hình Scrum.

## 🎯 Mục tiêu
- Hỗ trợ tạo dự án, phân công thành viên
- Quản lý Sprint, Backlog và các Task Breakdown
- Hiển thị công việc theo Kanban
- Dễ triển khai trong mạng nội bộ doanh nghiệp

## ⚙️ Công nghệ sử dụng
- Ngôn ngữ: **C#**
- Giao diện: **WinForms**
- Cơ sở dữ liệu: **MySQL**
- Trình quản lý CSDL: **MySQL Workbench**

## 🚀 Tính năng chính
- Đăng nhập người dùng
- Tạo và quản lý dự án
- Phân quyền thành viên theo dự án
- Tạo Sprint, Product/Sprint Backlog
- Tạo và giao task cho thành viên
- Giao diện Kanban: Not Started → In Progress → Review → Done

## 🧩 Cấu trúc cơ sở dữ liệu
Dự án sử dụng database tối giản với các bảng:
- Users
- Projects
- ProjectRoles
- User_Project
- Sprints
- Sprint_Backlog
- Tasks

## 👨‍👩‍👧‍👦 Thành viên nhóm
- Hồ Khánh Đăng
- Huỳnh Công Minh
- Võ Nguyễn Trung Kiên
- Châu Phương Đạt

## 📦 Cài đặt & chạy dự án

1. Clone repository:
```bash
git clone https://github.com/Tekaismyname/Software_Application_Taskmanagement.git
