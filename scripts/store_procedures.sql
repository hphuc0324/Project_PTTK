USE QUANLY_HOSO_UNGTUYEN;
GO

--TAO MA MOI
CREATE OR ALTER PROCEDURE sp_taoMa
@loaiDuLieu VARCHAR(20),
@ketQua VARCHAR(10) OUT
AS
BEGIN
	DECLARE @soluong INT 
	IF(@loaiDuLieu = 'Dang Tuyen')
	BEGIN
		SET @soluong = (SELECT COUNT(*) FROM THONGTINDANGTUYEN) + 1
		SET @ketQua = (SELECT 'DT' + FORMAT(@soluong, '000'))
	END
END
GO

--TAO DOI TAC. THANH CONG TRA VE 1, KHONG THANH CONG TRA VE 0
CREATE OR ALTER PROCEDURE sp_themDoiTac 
@maSoThue VARCHAR(10), 
@matKhau VARCHAR(50), 
@diaChi NVARCHAR(100), 
@email VARCHAR(50),
@tenCongTy NVARCHAR(50),
@nguoiDaiDien NVARCHAR(50)
AS
BEGIN
	BEGIN TRY
		INSERT INTO DOITAC VALUES(@maSoThue, @matKhau, @diaChi, @email, @tenCongTy, @nguoiDaiDien, null)
		SELECT 1;
	END TRY	
	BEGIN CATCH
		SELECT 0;
	END CATCH
END


EXEC sp_themDoiTac '24032003', '123', '227 Nguyen Van Cu', 'email@gmail.com', 'Hcmus', 'Hoang Phuc'
GO

--TAO THONG TIN DANG TUYEN
CREATE OR ALTER PROCEDURE sp_themDangTuyen
@soLuong INT,
@viTri NVARCHAR(50),
@thoiGianBatDau DATE,
@thoiGianKetThuc DATE,
@yeuCau NVARCHAR(50),
@hinhThuc NVARCHAR(20),
@maDoiTac VARCHAR(10)
AS
BEGIN
	BEGIN TRY
		DECLARE @maDangTuyen VARCHAR(20)
		EXEC sp_taoMa 'Dang Tuyen', @maDangTuyen OUT
		INSERT INTO THONGTINDANGTUYEN VALUES(@maDangTuyen ,@soLuong, @viTri, @thoiGianBatDau, @thoiGianKetThuc, @yeuCau, N'Chờ duyệt', @hinhThuc, @maDoiTac)

		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
END
GO


--THANH TOAN HOA DON
CREATE OR ALTER PROCEDURE sp_thanhToan
@maHoaDon VARCHAR(20)
AS
BEGIN
	BEGIN TRY
		UPDATE HOADON SET TinhTrang = N'Đã thanh toán' WHERE MaHoaDon = @maHoaDon

		SELECT 1;
	END TRY

	BEGIN CATCH
		SELECT 0;
	END CATCH
END
GO

CREATE OR ALTER PROCEDURE sp_kiemTraThanhToan
@maHoaDon VARCHAR(20)
AS
BEGIN
	BEGIN TRY
		DECLARE @trangThai NVARCHAR(20)
		SET @trangThai = (SELECT TinhTrang FROM HOADON WHERE MaHoaDon = @maHoaDon)

		IF(@trangThai = N'Chưa thanh toán')
		BEGIN
			SELECT 0
		END
		ELSE
		BEGIN
			SELECT 1
		END
	END TRY

	BEGIN CATCH
		SELECT 0
	END CATCH
END

EXEC sp_kiemTraThanhToan 'HD001'