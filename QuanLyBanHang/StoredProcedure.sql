create proc [dbo].[SP_AuthoLogin]
@Username nvarchar(20),
@Password nvarchar(20)
as
begin
    if exists (select * from QLTK where TaiKhoan = @Username and MatKhau = @Password)
        select 1 as code
    else if exists(select * from QLTK where TaiKhoan = @Username and MatKhau != @Password) 
        select 2 as code
    else select 3 as code
end