USE ems_db;

ALTER TABLE departments
	ADD COLUMN IF NOT EXISTS is_active TINYINT(1) NOT NULL DEFAULT 1;

ALTER TABLE positions
	ADD COLUMN IF NOT EXISTS is_active TINYINT(1) NOT NULL DEFAULT 1;

ALTER TABLE leave_types
	ADD COLUMN IF NOT EXISTS is_active TINYINT(1) NOT NULL DEFAULT 1;

ALTER TABLE leave_balances
	ADD COLUMN IF NOT EXISTS allocated_days DECIMAL(6,2) NOT NULL DEFAULT 0;

UPDATE leave_balances b
JOIN leave_types t ON t.leave_type_id = b.leave_type_id
SET b.allocated_days = t.days_allowed
WHERE b.allocated_days = 0;

ALTER TABLE users
	ADD COLUMN IF NOT EXISTS reset_token_expires_at DATETIME NULL;

ALTER TABLE payslips
	ADD COLUMN IF NOT EXISTS basic_salary DECIMAL(12,2) NOT NULL DEFAULT 0,
	ADD COLUMN IF NOT EXISTS allowances DECIMAL(12,2) NOT NULL DEFAULT 0,
	ADD COLUMN IF NOT EXISTS standard_deductions DECIMAL(12,2) NOT NULL DEFAULT 0;
