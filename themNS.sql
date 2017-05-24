create proc ThemNhanvien
@ma	varchar(10),
@mahienthi	nvarchar(20),
@hoten	nvarchar(200),
@quequan	nvarchar(100),
@diachi	nvarchar(100),
@gioitinh	int,
@ngaysinh	date,
@luong	int,
@chucvu	nvarchar(100)
as
begin
	insert into nhanvien values(@ma,@mahienthi,@hoten,@quequan,@diachi,@gioitinh,@ngaysinh,@luong,@chucvu)
end
	-----------------------
