create database DB_PTPM_QLTV
go use DB_PTPM_QLTV

use master
go drop database DB_PTPM_QLTV

create table TheLoai
(
	MaTheLoai int identity(1, 1),
	TenTheLoai nvarchar(100),
	constraint PK_TheLoai primary key (MaTheLoai)
)

create table Sach
(
	MaSach int identity(1, 1),
	TenSach nvarchar(100),
	AnhBia nvarchar(100),
	MaTheLoai int,
	NamXuatBan datetime,
	SoLuongSach int,
	constraint PK_Sach primary key (MaSach)
)

create table TacGia
(
	MaTacGia int identity(1, 1),
	HoTacGia nvarchar(30),
	TenTacGia nvarchar(50),
	constraint PK_TacGia primary key (MaTacGia)
)

create table SachTacGia
(
	MaSach int,
	MaTacGia int,
	constraint PK_Sach_TacGia primary key (MaSach, MaTacGia)
)

create table DocGia
(
	MaDocGia int identity(1, 1),
	HoDocGia nvarchar(30),
	TenDocGia nvarchar(50),
	NgayThamGia datetime,
	TinhTrang bit,
	constraint PK_DocGia primary key (MaDocGia)
)

create table MuonSach
(
	MaMuonSach int identity(1, 1),
	MaSach int,
	MaDocGia int,
	NgayMuonSach datetime,
	NgayTraSach datetime,
	constraint PK_MuonSach primary key (MaMuonSach)
)

-- Trường hợp sách mà độc giả muốn mượn nhưng sách đó đã mượn hết
-- thì độc giả có thể đặt trước sách đó để khi có thì có thể mượn
create table DatSach
(
	MaDatSach int identity(1, 1),
	MaSach int,
	MaDocGia int,
	NgayDatSach datetime,
	TinhTrang bit,
	constraint PK_DatSach primary key (MaDatSach)
)

create table PhatTreHan
(
	MaPhat int identity(1, 1),
	MaDocGia int,
	MaMuonSach int,
	NgayPhat datetime,
	SoTienPhat int,
	TinhTrang bit,
	GhiChu nvarchar(50),
	constraint PK_PhatTreHan primary key (MaPhat)
)

create table ThanhToanPhat
(
	MaThanhToan int identity(1, 1),
	MaDocGia int,
	NgayThanhToan datetime,
	SoTienThanhToan int,
	constraint PK_ThanhToanPhat primary key (SoTienThanhToan)
)

alter table Sach add
constraint FK_Sach_TheLoai foreign key (MaTheLoai) references TheLoai(MaTheLoai)

alter table SachTacGia add
constraint FK_STG_Sach foreign key (MaSach) references Sach(MaSach),
constraint FK_STG_TacGia foreign key (MaTacGia) references TacGia(MaTacGia)

alter table MuonSach add
constraint FK_MuonSach_Sach foreign key (MaSach) references Sach(MaSach),
constraint FK_MuonSach_DocGia foreign key (MaDocGia) references DocGia(MaDocGia)

alter table DatSach add
constraint FK_DatSach_Sach foreign key (MaSach) references Sach(MaSach),
constraint FK_DatSach_DocGia foreign key (MaDocGia) references DocGia(MaDocGia)

alter table PhatTreHan add
constraint FK_PhatTreHan_DocGia foreign key (MaDocGia) references DocGia(MaDocGia),
constraint FK_PhatTreHan_MuonSach foreign key (MaMuonSach) references MuonSach(MaMuonSach)

alter table ThanhToanPhat add
constraint FK_ThanhToanPhat_DocGia foreign key (MaDocGia) references DocGia(MaDocGia)

insert into TheLoai values
(N'Chính trị - pháp luật'),
(N'Khoa học công nghệ – Kinh tế'),
(N'Văn học nghệ thuật'),
(N'Văn hóa xã hội – Lịch sử'),
(N'Giáo trình'),
(N'Truyện'),
(N'Tiểu thuyết'),
(N'Tâm lý'),
(N'Tôn giáo'),
(N'Thiếu nhi')

select * from TheLoai