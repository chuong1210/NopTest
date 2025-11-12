Create database	QLTRUONGHOC;

go
USE  QLTRUONGHOC;

GO

CREATE TABLE HocVien (   
MaHV INT IDENTITY(1,1) PRIMARY KEY,  
TenHV NVARCHAR(255) ,   
Lop NVARCHAR(3) ,   


);

INSERT INTO HocVien 
VALUES (N'Nguyên Chương','DH8'),
 (N'Chí Thành','DH7'),
  (N'Chí Tài','DH8');


CREATE TABLE MonHoc (   
MaMH INT IDENTITY(1,1) PRIMARY KEY,  
TenMH NVARCHAR(255) ,   


);


INSERT INTO MonHoc 
VALUES (N'NoSQL'),
 (N'Lập trình Web'),
  (N'Lập trình Python');

CREATE TABLE BangDiem (   
MaHP INT IDENTITY(1,1) PRIMARY KEY,  
MaHV INT  ,  
MaMH INT,  
Diem FLOAT,
HeSo int,
NamHoc int,


CONSTRAINT FK_BangDiem_HocVien FOREIGN KEY (MaHV) REFERENCES HocVien(MaHV) ON DELETE CASCADE,
CONSTRAINT FK_BangDiem_MonHoc FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH) ON DELETE CASCADE


);


INSERT INTO BangDiem VALUES
(2,1,5.0,1,2026),
(3,1,7.0,1,2026),
(4,1,4.0,1,2026),
(2,2,6.0,1,2026),
(3,2,1.0,1,2026),
(4,2,4.0,1,2026),
(2,3,8.0,1,2026),
(3,3,3.0,1,2026),
(4,3,9.0,1,2026);


select h.MaHV, h.TenHV,(b.Diem*b.HeSo)/sum(b.HeSo)
as 'trung binh' 
from HocVien h INNER JOIN BangDiem b on h.MaHV=b.MaHV group by h.MaHV,h.TenHV,(b.Diem*b.HeSo)


select top 1  h.MaHV, h.TenHV,(SUM(b.Diem)/count(b.MaMH)) as dtb  from BangDiem b, HocVien h  
group by h.MaHV, h.TenHV,b.Diem,b.MaMH



