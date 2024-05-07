CREATE DATABASE QUANLY_HOSO_UNGTUYEN
GO

USE  QUANLY_HOSO_UNGTUYEN
GO

CREATE TABLE DOITAC
(
	MaSoThue VARCHAR(10) PRIMARY KEY, --Lay ma so thue lam tai khoan
	MatKhau VARCHAR(50),
	DiaChi NVARCHAR(100),
	Email VARCHAR(50),
	TenCongTy NVARCHAR(50),
	NguoiDaiDien NVARCHAR(50),
	TiemNang NVARCHAR(50)
)
GO

CREATE TABLE THONGTINDANGTUYEN
(
	MaDangTuyen VARCHAR(20) PRIMARY KEY,
	SoLuongTuyenDung INT,
	ViTriTuyenDung NVARCHAR(50),
	ThoiGianBatDau DATE,
	ThoiGianKetThuc DATE,
	YeuCauUngVien NVARCHAR(50),
	TrangThai NVARCHAR(20),
	HinhThuc NVARCHAR(20),
	MaDoiTac VARCHAR(10),

	CONSTRAINT FK_MADOITAC FOREIGN KEY(MaDoiTac) REFERENCES DOITAC(MaSoThue)
)
GO

CREATE TABLE NHANVIEN
(
	MaNV VARCHAR(20) PRIMARY KEY,
	MatKhau VARCHAR(20),
	HoTen NVARCHAR(50),
	VaiTro NVARCHAR(20)
)
GO

CREATE TABLE PHIEUDANGTUYEN
(
	MaPhieu VARCHAR(20) PRIMARY KEY,
	HinhThuc NVARCHAR(20),
	MaNVDuyet VARCHAR(20),
	MaTTDangTuyen VARCHAR(20)

	CONSTRAINT FK_MANVDUYET FOREIGN KEY(MaNVDuyet) REFERENCES NHANVIEN(MaNV),
	CONSTRAINT FK_MATTDANGTUYEN FOREIGN KEY(MaTTDangTuyen) REFERENCES THONGTINDANGTUYEN(MaDangTuyen)
)
GO

CREATE TABLE HOADON
(
	MaHoaDon VARCHAR(20) PRIMARY KEY,
	TinhTrang NVARCHAR(20),
	TongTien INT,
	MaPhieuDangTuyen VARCHAR(20)

	CONSTRAINT FK_MAPHIEUDANGTUYEN FOREIGN KEY(MaPhieuDangTuyen) REFERENCES PHIEUDANGTUYEN(MaPhieu)
)
GO

CREATE TABLE THANHVIEN
(
	MaThanhVien VARCHAR(20) PRIMARY KEY,
	SoDienThoai VARCHAR(10),
	HoTen NVARCHAR(50),
	MatKhau VARCHAR(50),
	Email VARCHAR(50)
)
GO

CREATE TABLE PHIEUUNGTUYEN
(
	MaUngTuyen VARCHAR(20) PRIMARY KEY,
	TinhTrang NVARCHAR(20),
	MaTTDangTuyen VARCHAR(20),
	MaNVDuyet VARCHAR(20),
	MaTV VARCHAR(20)

	CONSTRAINT FK_MATTDANGTUYEN_UT FOREIGN KEY(MaTTDangTuyen) REFERENCES THONGTINDANGTUYEN(MaDangTuyen),
	CONSTRAINT FK_MANVDUYET_UT FOREIGN KEY(MaNVDuyet) REFERENCES NHANVIEN(MaNV),
	CONSTRAINT FK_MATV FOREIGN KEY(MaTV) REFERENCES THANHVIEN(MaThanhVien)
)
GO

CREATE TABLE CHUNGTU
(
	MaCT VARCHAR(20) PRIMARY KEY,
	TenCT NVARCHAR(50)
)
GO

CREATE TABLE UNGTUYEN_CHUNGTU
(
	MaPhieuUngTuyen VARCHAR(20) ,
	MaChungTu VARCHAR(20)


	CONSTRAINT FK_MAPHIEUUNGTUYEN FOREIGN KEY(MaPhieuUngTuyen) REFERENCES PHIEUUNGTUYEN(MaUngTuyen),
	CONSTRAINT FK_MACHUNGTU FOREIGN KEY(MaChungTu) REFERENCES CHUNGTU(MaCT),

	
	PRIMARY KEY(MaPhieuUngTuyen, MaChungTu)
)
GO