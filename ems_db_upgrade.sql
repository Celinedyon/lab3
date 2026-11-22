USE ems_db;

INSERT IGNORE INTO departments (name, is_active) VALUES
	('HR', 1), ('Finance', 1), ('IT', 1), ('Operations', 1);

ALTER TABLE departments
	ADD COLUMN IF NOT EXISTS is_active TINYINT(1) NOT NULL DEFAULT 1;

ALTER TABLE positions
	ADD COLUMN IF NOT EXISTS is_active TINYINT(1) NOT NULL DEFAULT 1,
	ADD COLUMN IF NOT EXISTS department_id INT NULL;

SET @position_department_fk_exists = (
	SELECT COUNT(*) FROM information_schema.TABLE_CONSTRAINTS
	WHERE CONSTRAINT_SCHEMA = DATABASE() AND TABLE_NAME = 'positions'
		AND CONSTRAINT_NAME = 'fk_position_department'
);
SET @position_department_fk_sql = IF(@position_department_fk_exists = 0,
	'ALTER TABLE positions ADD CONSTRAINT fk_position_department FOREIGN KEY (department_id) REFERENCES departments(department_id)',
	'SELECT 1'
);
PREPARE position_department_fk_statement FROM @position_department_fk_sql;
EXECUTE position_department_fk_statement;
DEALLOCATE PREPARE position_department_fk_statement;

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
