﻿USE DoVuiKienThuc;
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

CREATE PROCEDURE sp_LayCauHoiNgauNhien
AS
BEGIN
    SELECT TOP 1 * 
    FROM CauHoi 
    ORDER BY NEWID();
END
GO
