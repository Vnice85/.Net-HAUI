CREATE DATABASE QLBanHang
ON PRIMARY 
(
NAME = 'QLBanHang',
FILENAME = 'D:\QLBanHang.mdf',
SIZE = 8MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 64MB
)
LOG ON
(
NAME = 'QLBanHang_LOG',
FILENAME = 'D:\QLBanHang.ldf',
SIZE = 8MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 64MB
)
go
use [QLBanHang]
go
------------------------------------------------------
Create table NguoiDung
(
TenDangNhap varchar(10) not null primary key,
MatKhau varchar(10),
HoTen nvarchar(50)
)
------------------------------------------------------------
CREATE TABLE KhachHang
(
MaKH char(4) not null primary key,
TenKH nvarchar(50),
SoDT varchar(12),
DiaChi nvarchar(50)
)
------------------------------------------------------------------
CREATE TABLE HoaDon 
(
MaHD char(4) not null primary key,
NgayLap date,
MaKH char(4),
NguoiLap varchar(10),
constraint FK_HoaDon_KhachHang foreign key(MaKH) references KhachHang(MaKH)  on update cascade on delete cascade,
constraint FK_HoaDon_NguoiDung foreign key(NguoiLap) references NguoiDung(TenDangNhap)  on update cascade on delete cascade
)
----------------------------------------------------------------
create table LoaiSanPham
(
MaLoai char(3) not null primary key,
TenLoai nvarchar(50)
)
--------------------------------------------------------
CREATE TABLE SanPham
(
MaSP char(4) not null primary key,
TenSP nvarchar(50),
MaLoai char(3),
SoLuong int,
DonGia int,
constraint FK_SanPham_LoaiSanPham foreign key(MaLoai) references LoaiSanPham(MaLoai)  on update cascade on delete cascade
)
----------------------------------------------------
CREATE TABLE HoaDonChiTiet
(
MaHD char(4) not null,
MaSP char(4) not null,
SoLuongMua int,
constraint PK_HoaDonChiTiet primary key(MaHD,MaSP),
constraint FK_HoaDonChiTiet_HoaDon foreign key(MaHD) references HoaDon(MaHD) on update cascade on delete cascade,
constraint Fk_HoaDonChiTiet_SanPham foreign key(MaSP) references SanPham(MaSP)  on update cascade on delete cascade
)
insert into NguoiDung values ('N01','124',N'Vu Duc Van'),
							 ('N02','124',N'Nguyen Manh Nien'),
							 ('N03','124',N'Nguyen Tien Dat')
insert into KhachHang values ('M01','Vu Duc Van', '12345678980', 'Nam Dinh'),
							 ('M02','Nguyen Manh Nien', '12345678980', 'Vinh Phuc'),
							 ('M03','Nguyen Tien Dat', '12345678980', 'Nam Dinh')
insert into HoaDon values ('H01', '2022-10-10', 'M01', 'N01'),
						  ('H02', '2022-10-10', 'M02', 'N02'),
						  ('H03', '2022-10-10', 'M03', 'N03')
insert into LoaiSanPham values ('L1', N'Vip1'),
							   ('L2', N'Vip2'),
							   ('L3', N'Normal')
insert into SanPham values ('SP01', N'bom', 'L1', 2, 100),
							('SP02', N'súng', 'L2', 5, 600),
							('SP03', N'dao', 'L3', 4, 200)
insert into HoaDonChiTiet values ('H01', 'SP01', 5),
							     ('H02', 'SP02', 10),
								 ('H03', 'SP03', 2)

								select * from HoaDon
								select * from HoaDonChiTiet
								select * from KhachHang
								select * from LoaiSanPham
								select * from NguoiDung
								select * from SanPham
