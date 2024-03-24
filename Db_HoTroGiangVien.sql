Create DATABASE HoTroGiangVien
go
use HoTroGiangVien
go
CREATE TABLE TaiKhoan(
id VARCHAR(255) PRIMARY KEY,
mk VARCHAR(255))



CREATE TABLE Users (
    id VARCHAR(255) FOREIGN KEY REFERENCES TaiKhoan(id),
    email NVARCHAR(100) UNIQUE NOT NULL,
    full_name NVARCHAR(100),
    phone_number NVARCHAR(20),
    address NVARCHAR(255),
	sohd VARCHAR(255),
	ngayhethan DATE

);

CREATE TABLE TeachingSchedule (
    id  VARCHAR(255) FOREIGN KEY REFERENCES TaiKhoan(id),
    date DATE NOT NULL,
    ca Nvarchar(255)
);


select * from TeachingSchedule
-- Tạo bảng Tính lương
CREATE TABLE SalaryCalculations (
    calculation_id INT PRIMARY KEY IDENTITY,
    id VARCHAR(255) FOREIGN KEY REFERENCES TaiKhoan(id),
    month DATE NOT NULL,
    total_hours DECIMAL(10, 2) NOT NULL,
    total_earnings DECIMAL(10, 2) NOT NULL
);

-- Tạo bảng Quản lý phiên
CREATE TABLE SessionManagement (
    session_id INT PRIMARY KEY IDENTITY,
    id VARCHAR(255) FOREIGN KEY REFERENCES TaiKhoan(id),
    token NVARCHAR(255) NOT NULL,
    expiration_time DATETIME NOT NULL
);

go
CREATE PROC proc_logic
@user varchar(255),
@pass varchar(255)
as
begin
	select * from TaiKhoan where id=@user and mk=@pass
end
go
INSERT INTO TaiKhoan (id, mk) VALUES ('52200123', '123');
INSERT INTO Users (id, email, full_name, phone_number, address, sohd, ngayhethan)
VALUES ('52200123', '52200123', 'Trịnh lê tuyết nhung', '123456789', 'quận 7', '1231135', '2024-03-08');
select *from  Users
select * from TaiKhoan
