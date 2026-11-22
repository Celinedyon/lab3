CREATE DATABASE IF NOT EXISTS ems_db CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE ems_db;

CREATE TABLE IF NOT EXISTS departments (
	department_id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(100) NOT NULL UNIQUE,
	manager_id INT NULL,
	is_active TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS positions (
	position_id INT AUTO_INCREMENT PRIMARY KEY,
	title VARCHAR(100) NOT NULL UNIQUE,
	department_id INT NULL,
	is_active TINYINT(1) NOT NULL DEFAULT 1,
	FOREIGN KEY (department_id) REFERENCES departments(department_id)
);

INSERT IGNORE INTO departments (name, is_active) VALUES
	('HR', 1), ('Finance', 1), ('IT', 1), ('Operations', 1);

CREATE TABLE IF NOT EXISTS employees (
	employee_id INT AUTO_INCREMENT PRIMARY KEY,
	employee_code VARCHAR(30) NOT NULL UNIQUE,
	first_name VARCHAR(80) NOT NULL,
	last_name VARCHAR(80) NOT NULL,
	email VARCHAR(150) NOT NULL UNIQUE,
	phone VARCHAR(40) NULL,
	date_of_birth DATE NULL,
	gender VARCHAR(20) NULL,
	address VARCHAR(255) NULL,
	hire_date DATE NOT NULL,
	department_id INT NULL,
	position_id INT NULL,
	status ENUM('Active','On Leave','Suspended','Terminated') NOT NULL DEFAULT 'Active',
	emergency_name VARCHAR(150) NULL,
	emergency_phone VARCHAR(40) NULL,
	FOREIGN KEY (department_id) REFERENCES departments(department_id),
	FOREIGN KEY (position_id) REFERENCES positions(position_id)
);

CREATE TABLE IF NOT EXISTS salaries (
	employee_id INT PRIMARY KEY,
	basic_salary DECIMAL(12,2) NOT NULL DEFAULT 0,
	allowances DECIMAL(12,2) NOT NULL DEFAULT 0,
	deductions DECIMAL(12,2) NOT NULL DEFAULT 0,
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id)
);

CREATE TABLE IF NOT EXISTS users (
	user_id INT AUTO_INCREMENT PRIMARY KEY,
	email VARCHAR(150) NOT NULL UNIQUE,
	password_hash VARCHAR(255) NOT NULL,
	role ENUM('Administrator','HR Officer','Manager','Employee') NOT NULL,
	is_active TINYINT(1) NOT NULL DEFAULT 1,
	employee_id INT NULL,
	reset_token VARCHAR(100) NULL,
	reset_token_expires_at DATETIME NULL,
	created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id)
);

SET @reset_token_exists = (SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'users' AND COLUMN_NAME = 'reset_token');
SET @sql = IF(@reset_token_exists = 0,
	'ALTER TABLE users ADD COLUMN reset_token VARCHAR(100) NULL', 'SELECT 1');
PREPARE add_reset_token FROM @sql;
EXECUTE add_reset_token;
DEALLOCATE PREPARE add_reset_token;

SET @reset_expiry_exists = (SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS
	WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'users' AND COLUMN_NAME = 'reset_token_expires_at');
SET @sql = IF(@reset_expiry_exists = 0,
	'ALTER TABLE users ADD COLUMN reset_token_expires_at DATETIME NULL', 'SELECT 1');
PREPARE add_reset_expiry FROM @sql;
EXECUTE add_reset_expiry;
DEALLOCATE PREPARE add_reset_expiry;

SET @ems_department_manager_fk_exists = (
	SELECT COUNT(*) FROM information_schema.TABLE_CONSTRAINTS
	WHERE CONSTRAINT_SCHEMA = DATABASE() AND TABLE_NAME = 'departments'
		AND CONSTRAINT_NAME = 'fk_department_manager'
);
SET @ems_department_manager_fk_sql = IF(@ems_department_manager_fk_exists = 0,
	'ALTER TABLE departments ADD CONSTRAINT fk_department_manager FOREIGN KEY (manager_id) REFERENCES employees(employee_id)',
	'SELECT 1'
);
PREPARE ems_department_manager_fk_statement FROM @ems_department_manager_fk_sql;
EXECUTE ems_department_manager_fk_statement;
DEALLOCATE PREPARE ems_department_manager_fk_statement;

CREATE TABLE IF NOT EXISTS attendance (
	attendance_id INT AUTO_INCREMENT PRIMARY KEY,
	employee_id INT NOT NULL,
	work_date DATE NOT NULL,
	clock_in TIME NULL,
	clock_out TIME NULL,
	hours_worked DECIMAL(5,2) NULL,
	status ENUM('Present','Late','Absent') NOT NULL DEFAULT 'Present',
	correction_reason VARCHAR(255) NULL,
	corrected_by INT NULL,
	UNIQUE KEY uq_attendance_employee_date (employee_id, work_date),
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
	FOREIGN KEY (corrected_by) REFERENCES users(user_id)
);

CREATE TABLE IF NOT EXISTS leave_types (
	leave_type_id INT AUTO_INCREMENT PRIMARY KEY,
	name VARCHAR(80) NOT NULL UNIQUE,
	days_allowed DECIMAL(6,2) NOT NULL DEFAULT 0,
	is_paid TINYINT(1) NOT NULL DEFAULT 1,
	is_active TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS leave_requests (
	request_id INT AUTO_INCREMENT PRIMARY KEY,
	employee_id INT NOT NULL,
	leave_type_id INT NOT NULL,
	start_date DATE NOT NULL,
	end_date DATE NOT NULL,
	days INT NOT NULL,
	reason VARCHAR(500) NOT NULL,
	status ENUM('Pending','Approved','Rejected') NOT NULL DEFAULT 'Pending',
	reviewed_by INT NULL,
	reviewed_at DATETIME NULL,
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
	FOREIGN KEY (leave_type_id) REFERENCES leave_types(leave_type_id),
	FOREIGN KEY (reviewed_by) REFERENCES users(user_id)
);

CREATE TABLE IF NOT EXISTS leave_balances (
	employee_id INT NOT NULL,
	leave_type_id INT NOT NULL,
	year SMALLINT NOT NULL,
	allocated_days DECIMAL(6,2) NOT NULL DEFAULT 0,
	days_used DECIMAL(6,2) NOT NULL DEFAULT 0,
	PRIMARY KEY (employee_id, leave_type_id, year),
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
	FOREIGN KEY (leave_type_id) REFERENCES leave_types(leave_type_id)
);

CREATE TABLE IF NOT EXISTS payroll_runs (
	run_id INT AUTO_INCREMENT PRIMARY KEY,
	pay_month TINYINT NOT NULL,
	pay_year SMALLINT NOT NULL,
	is_locked TINYINT(1) NOT NULL DEFAULT 0,
	UNIQUE KEY uq_payroll_period (pay_month, pay_year)
);

CREATE TABLE IF NOT EXISTS payslips (
	payslip_id INT AUTO_INCREMENT PRIMARY KEY,
	run_id INT NOT NULL,
	employee_id INT NOT NULL,
	basic_salary DECIMAL(12,2) NOT NULL DEFAULT 0,
	allowances DECIMAL(12,2) NOT NULL DEFAULT 0,
	standard_deductions DECIMAL(12,2) NOT NULL DEFAULT 0,
	gross_pay DECIMAL(12,2) NOT NULL DEFAULT 0,
	total_deductions DECIMAL(12,2) NOT NULL DEFAULT 0,
	unpaid_deduction DECIMAL(12,2) NOT NULL DEFAULT 0,
	net_pay DECIMAL(12,2) NOT NULL DEFAULT 0,
	issued_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	UNIQUE KEY uq_payslip_employee_run (run_id, employee_id),
	FOREIGN KEY (run_id) REFERENCES payroll_runs(run_id),
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id)
);

CREATE TABLE IF NOT EXISTS goals (
	goal_id INT AUTO_INCREMENT PRIMARY KEY,
	employee_id INT NOT NULL,
	set_by INT NOT NULL,
	description VARCHAR(500) NOT NULL,
	due_date DATE NULL,
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
	FOREIGN KEY (set_by) REFERENCES users(user_id)
);

CREATE TABLE IF NOT EXISTS reviews (
	review_id INT AUTO_INCREMENT PRIMARY KEY,
	employee_id INT NOT NULL,
	reviewer_id INT NOT NULL,
	rating TINYINT NOT NULL,
	comments TEXT NULL,
	review_date DATE NOT NULL,
	FOREIGN KEY (employee_id) REFERENCES employees(employee_id),
	FOREIGN KEY (reviewer_id) REFERENCES users(user_id)
);

CREATE TABLE IF NOT EXISTS notifications (
	notification_id INT AUTO_INCREMENT PRIMARY KEY,
	user_id INT NOT NULL,
	message VARCHAR(500) NOT NULL,
	is_read TINYINT(1) NOT NULL DEFAULT 0,
	created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
	FOREIGN KEY (user_id) REFERENCES users(user_id)
);

INSERT IGNORE INTO leave_types (name, days_allowed, is_paid) VALUES
	('Annual', 21, 1), ('Sick', 10, 1), ('Maternity', 90, 1),
	('Paternity', 7, 1), ('Unpaid', 30, 0);
