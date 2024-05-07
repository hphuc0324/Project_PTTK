USE QUANLY_HOSO_UNGTUYEN;
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
