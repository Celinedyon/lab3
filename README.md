# Employee Management System (EMS)

**Architecture:** MVC (Model - View - Controller)  
**Technology:** C# .NET Windows Forms, MySQL / MariaDB (XAMPP), BCrypt.Net  

---

## 📌 Overview

This project is a Windows Forms desktop application designed to manage employee records, organizational departments, daily attendance, leave requests, monthly payroll, and performance reviews. It implements comprehensive features for human resource and workforce management.

---

## 🔑 Default Administrator Credentials

When the application launches for the first time, it automatically ensures the default administrator account exists:
- **Email:** `admin@ems.com`
- **Password:** `Admin@123`
- **Role:** Administrator

*(Note: Passwords are automatically hashed with BCrypt before storage in MySQL).*

---

## 🗄️ Database Setup

1. Start **Apache** and **MySQL** in the **XAMPP Control Panel**.
2. Open phpMyAdmin (`http://localhost/phpmyadmin`) or MySQL CLI.
3. Import the database script:
   - Run or import `ems_db.sql`.
   - The database connects to `localhost:3306` with user `root` and an empty password by default. If your MySQL credentials differ, update them in `EmployeeManagementSystem/Data/Database.cs`.

---

## 🏗️ Architecture & Project Structure (MVC)

The project strictly follows the **Model-View-Controller (MVC)** architectural pattern:

```text
EmployeeManagementSystem/
├── Model/               # POCO Entities representing database tables
│   ├── Employee.cs
│   ├── Department.cs
│   ├── Position.cs
│   ├── User.cs
│   ├── Attendance.cs
│   ├── LeaveRequest.cs
│   ├── LeaveBalance.cs
│   ├── Payroll.cs
│   ├── Payslip.cs
│   └── Performance.cs
├── Controllers/         # Business logic and database operations
│   ├── AuthController.cs
│   ├── EmployeeController.cs
│   ├── AttendanceController.cs
│   ├── LeaveController.cs
│   ├── PayrollController.cs
│   ├── PerformanceController.cs
│   └── ReportsController.cs
├── View/                # Windows Forms (Standard Visual Studio controls)
│   ├── LoginForm.cs
│   ├── MainForm.cs
│   ├── EmployeeEditForm.cs
│   ├── EmployeesForm.cs
│   ├── AttendanceForm.cs
│   ├── LeaveForm.cs
│   ├── PayrollForm.cs
│   └── ViewTheme.cs
└── Data/
    └── Database.cs      # MySQL connection manager
```

---

## 🚀 How to Run

1. Open the solution in **Visual Studio 2022**.
2. Ensure MySQL is running in XAMPP.
3. Press **F5** or click **Start** to run `EmployeeManagementSystem`.
