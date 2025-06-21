USE DoVuiKienThuc;
GO

-- STORED PROCEDURE: LẤY CÂU HỎI NGẪU NHIÊN THEO CHỦ ĐỀ
CREATE PROCEDURE sp_LayCauHoiNgauNhienTheoChuDe
    @ChuDeID INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 * 
    FROM CauHoi 
    WHERE ChuDeID = @ChuDeID
    ORDER BY NEWID();
END;
GO

-- STORED PROCEDURE: LẤY CÂU HỎI NGẪU NHIÊN BẤT KỲ
CREATE PROCEDURE sp_LayCauHoiNgauNhien
AS
BEGIN
    SELECT TOP 1 * 
    FROM CauHoi 
    ORDER BY NEWID();
END;
GO

-- STORED PROCEDURE: THÊM ĐIỂM VÀO XẾP HẠNG
CREATE PROCEDURE sp_ThemDiemXepHang
    @Diem INT,
    @ThoiGianTraLoi INT,
    @ChuDeID INT
AS
BEGIN
    INSERT INTO XepHang (Diem, ThoiGianTraLoi, ChuDeID)
    VALUES (@Diem, @ThoiGianTraLoi, @ChuDeID);
END;
GO