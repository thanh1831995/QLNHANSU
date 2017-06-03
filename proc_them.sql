
create proc themnv(
@MaNhanVien varchar(10),
@TenNhanVien nvarchar(50),
@NgaySinh datetime,
@Luong money,
@QueQuan nvarchar(50),
@MaPhong varchar(10)
)
AS 
begin
	insert into NhanVien values(@MaNhanVien,@TenNhanVien,@NgaySinh,@Luong,@QueQuan,@MaPhong)
end
