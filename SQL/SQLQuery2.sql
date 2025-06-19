USE DoVuiKienThuc;
GO

CREATE PROCEDURE sp_LayCauHoiNgauNhienTheoChuDe
    @ChuDeID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 * 
    FROM CauHoi 
    WHERE ChuDeID = @ChuDeID
    ORDER BY NEWID();
END
GO
