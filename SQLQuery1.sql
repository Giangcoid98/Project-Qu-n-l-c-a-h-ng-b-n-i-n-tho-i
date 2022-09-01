CREATE PROC USP_GETaccountbyusername
@UserName NVARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.Account WHERE UserName = @UserName
END
GO
EXEC dbo.USP_GETaccountbyusername @UserName = N'Admin'
GO
CREATE PROC USP_GETnamebyMaNV
@MaNV VARCHAR(20)
AS 
BEGIN
SELECT * FROM dbo.Nhanvien WHERE MaNV = @MaNV
END
GO
EXEC dbo.USP_GETnamebyMaNV @MaNV = N'002'

