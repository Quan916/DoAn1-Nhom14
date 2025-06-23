USE DoVuiKienThuc;
GO

-- BẢNG CHỦ ĐỀ
CREATE TABLE ChuDe (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenChuDe NVARCHAR(100) NOT NULL
);
GO

ALTER TABLE ChuDe 
ADD CONSTRAINT UQ_TenChuDe UNIQUE (TenChuDe);
GO

-- BẢNG CÂU HỎI
CREATE TABLE CauHoi (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ChuDeID INT NOT NULL,
    NoiDung NVARCHAR(MAX) NOT NULL,
    DapAnA NVARCHAR(255),
    DapAnB NVARCHAR(255),
    DapAnC NVARCHAR(255),
    DapAnD NVARCHAR(255),
    DapAnDung CHAR(1) CHECK (DapAnDung IN ('A', 'B', 'C', 'D')) NOT NULL,
    GiaiThich NVARCHAR(MAX),
    HinhAnh NVARCHAR(255), -- Đường dẫn ảnh minh họa (nếu có)
    CONSTRAINT FK_CauHoi_ChuDe 
        FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);
GO

ALTER TABLE CauHoi
ADD CONSTRAINT UQ_NoiDung UNIQUE (NoiDung); -- Chống trùng câu hỏi
GO

-- BẢNG XẾP HẠNG
CREATE TABLE XepHang (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Diem INT NOT NULL CHECK (Diem >= 0),
    ThoiGianTraLoi INT NOT NULL CHECK (ThoiGianTraLoi >= 0),
    ThoiGian DATETIME DEFAULT GETDATE(),
    ChuDeID INT,
    DoiChoiID INT NULL
);
GO

ALTER TABLE XepHang
ADD CONSTRAINT FK_XepHang_ChuDe
    FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
    ON DELETE SET NULL
    ON UPDATE CASCADE;
GO

-- BẢNG ĐỘI CHƠI (đấu đôi/đội)
CREATE TABLE DoiChoi (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenDoi NVARCHAR(100) NOT NULL
);
GO

ALTER TABLE XepHang
ADD CONSTRAINT FK_XepHang_DoiChoi
    FOREIGN KEY (DoiChoiID) REFERENCES DoiChoi(ID)
    ON DELETE SET NULL
    ON UPDATE CASCADE;
GO

-- DỮ LIỆU CHỦ ĐỀ MẪU
INSERT INTO ChuDe (TenChuDe) VALUES 
(N'Lịch sử'), (N'Khoa học'), (N'Địa lý'), (N'Thể thao'),
(N'Âm nhạc'), (N'Công nghệ'), (N'Văn học'), (N'Thế giới'), (N'Hóa học');
GO

-- PROCEDURE: LẤY 1 CÂU HỎI NGẪU NHIÊN THEO CHỦ ĐỀ
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

-- PROCEDURE: LẤY 1 CÂU HỎI NGẪU NHIÊN KHÔNG THEO CHỦ ĐỀ
CREATE PROCEDURE sp_LayCauHoiNgauNhien
AS
BEGIN
    SELECT TOP 1 * 
    FROM CauHoi 
    ORDER BY NEWID();
END;
GO

-- PROCEDURE: LƯU ĐIỂM VÀO XẾP HẠNG
CREATE PROCEDURE sp_ThemDiemXepHang
    @Diem INT,
    @ThoiGianTraLoi INT,
    @ChuDeID INT = NULL,
    @DoiChoiID INT = NULL
AS
BEGIN
    INSERT INTO XepHang (Diem, ThoiGianTraLoi, ChuDeID, DoiChoiID)
    VALUES (@Diem, @ThoiGianTraLoi, @ChuDeID, @DoiChoiID);
END;
GO

-- VIEW: XẾP HẠNG CHI TIẾT
CREATE VIEW vw_XepHangChiTiet AS
SELECT 
    ROW_NUMBER() OVER (ORDER BY XH.Diem DESC, XH.ThoiGianTraLoi ASC) AS STT,
    CH.TenChuDe,
    DC.TenDoi,
    XH.Diem,
    XH.ThoiGianTraLoi,
    XH.ThoiGian
FROM XepHang AS XH
LEFT JOIN ChuDe AS CH ON XH.ChuDeID = CH.ID
LEFT JOIN DoiChoi AS DC ON XH.DoiChoiID = DC.ID;
GO

-- VIEW: THỐNG KÊ ĐIỂM TRUNG BÌNH THEO CHỦ ĐỀ
CREATE VIEW vw_ThongKeXepHang AS
SELECT 
    CH.TenChuDe,
    COUNT(*) AS SoLuotChoi,
    AVG(Diem) AS DiemTrungBinh,
    MIN(ThoiGianTraLoi) AS NhanhNhat,
    MAX(Diem) AS DiemCaoNhat
FROM XepHang X
LEFT JOIN ChuDe CH ON X.ChuDeID = CH.ID
GROUP BY CH.TenChuDe;
GO

-- VIEW: ĐẾM TỔNG SỐ CÂU HỎI MỖI CHỦ ĐỀ
CREATE VIEW vw_TongSoCauHoiTheoChuDe AS
SELECT CH.TenChuDe, COUNT(*) AS TongCauHoi
FROM CauHoi C
JOIN ChuDe CH ON C.ChuDeID = CH.ID
GROUP BY CH.TenChuDe;
GO
