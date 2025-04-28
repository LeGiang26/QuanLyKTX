USE QUANLYKYTUCXA
GO
/* Thêm nhân viên */
CREATE PROC uspThemNhanVien
	@manv nchar(10),
	@tennv nvarchar (50),
	@gioitinh nvarchar (10),
	@ngaysinh date,
	@diachi nvarchar(50),
	@sodienthoai nchar(15)
AS
BEGIN
	INSERT INTO NhanVien (maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDienThoai) 
	VALUES(@manv, @tennv, @gioitinh, @ngaysinh, @diachi, @sodienthoai);
END
GO
/* Xóa nhân viên */
CREATE PROC uspXoaNhanVien
    @manv nchar(10)
AS
BEGIN
    DELETE FROM NhanVien WHERE maNV = @manv;
END
GO
/* Cập nhập nhân viên */
CREATE PROC uspCapNhapNhanVien
    @manv nchar(10),
    @tennv nvarchar(50),
    @gioitinh nvarchar(10),
    @ngaysinh date,
    @diachi nvarchar(50),
    @sodienthoai nchar(15)
AS
BEGIN
    UPDATE NhanVien 
    SET 
        tenNV = @tennv,
        gioiTinh = @gioitinh,
        ngaySinh = @ngaysinh,
        diaChi = @diachi,
        soDienThoai = @sodienthoai
    WHERE maNV = @manv;
END
GO