USE DoVuiKienThuc;
GO

--  BẢNG CHỦ ĐỀ
CREATE TABLE ChuDe (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenChuDe NVARCHAR(100) NOT NULL UNIQUE
);
GO

--  BẢNG CÂU HỎI
CREATE TABLE CauHoi (
    ID INT PRIMARY KEY IDENTITY(1,1),
    ChuDeID INT NOT NULL,
    NoiDung NVARCHAR(MAX) NOT NULL UNIQUE,
    DapAnA NVARCHAR(255),
    DapAnB NVARCHAR(255),
    DapAnC NVARCHAR(255),
    DapAnD NVARCHAR(255),
    DapAnDung CHAR(1) CHECK (DapAnDung IN ('A', 'B', 'C', 'D')) NOT NULL,
    GiaiThich NVARCHAR(MAX),
    HinhAnh NVARCHAR(255),
    CONSTRAINT FK_CauHoi_ChuDe 
        FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
        ON DELETE CASCADE ON UPDATE CASCADE
);
GO

--  BẢNG ĐỘI CHƠI
CREATE TABLE DoiChoi (
    ID INT PRIMARY KEY IDENTITY(1,1),
    TenDoi NVARCHAR(100) NOT NULL
);
GO

ALTER TABLE DoiChoi
ADD CONSTRAINT UQ_TenDoi UNIQUE (TenDoi);
GO

--  BẢNG XẾP HẠNG
CREATE TABLE XepHang (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Diem INT NOT NULL CHECK (Diem >= 0),
    ThoiGianTraLoi INT NOT NULL CHECK (ThoiGianTraLoi >= 0),
    ThoiGian DATETIME DEFAULT GETDATE(),
    ChuDeID INT NULL,
    DoiChoiID INT NULL,
    FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
        ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY (DoiChoiID) REFERENCES DoiChoi(ID)
        ON DELETE SET NULL ON UPDATE CASCADE
);
GO

--  DỮ LIỆU MẪU
INSERT INTO ChuDe (TenChuDe) VALUES 
(N'Lịch sử'), 
(N'Khoa học'), 
(N'Địa lý'), 
(N'Thể thao'),
(N'Nghệ thuật'), 
(N'Công nghệ'), 
(N'Văn học'), 
(N'Thế giới'), 
(N'Hóa học');
GO

--  PROCEDURES

-- Lấy câu hỏi ngẫu nhiên theo chủ đề
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

-- Lấy câu hỏi ngẫu nhiên không theo chủ đề
CREATE PROCEDURE sp_LayCauHoiNgauNhien
AS
BEGIN
    SELECT TOP 1 * 
    FROM CauHoi 
    ORDER BY NEWID();
END;
GO

-- Lưu điểm vào bảng Xếp Hạng
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

-- Điểm cao nhất theo tên chủ đề
CREATE PROCEDURE sp_LayDiemCaoNhatTheoChuDe
    @TenChuDe NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MAX(XH.Diem) AS DiemCaoNhat
    FROM XepHang XH
    INNER JOIN ChuDe CD ON XH.ChuDeID = CD.ID
    WHERE CD.TenChuDe = @TenChuDe;
END;
GO

--  VIEWS

-- View chi tiết xếp hạng
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

-- View xếp hạng đội nhóm
CREATE VIEW vw_XepHangDoiNhom AS
SELECT 
    DC.TenDoi,
    MAX(XH.Diem) AS DiemCaoNhat,
    AVG(XH.Diem) AS DiemTrungBinh,
    COUNT(*) AS SoLuotChoi
FROM XepHang XH
JOIN DoiChoi DC ON XH.DoiChoiID = DC.ID
GROUP BY DC.TenDoi;
GO

-- Thống kê điểm theo chủ đề
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

-- Tổng số câu hỏi theo chủ đề
CREATE VIEW vw_TongSoCauHoiTheoChuDe AS
SELECT CH.TenChuDe, COUNT(*) AS TongCauHoi
FROM CauHoi C
JOIN ChuDe CH ON C.ChuDeID = CH.ID
GROUP BY CH.TenChuDe;
GO

--  Index
CREATE INDEX IX_CauHoi_ChuDeID ON CauHoi(ChuDeID);
CREATE INDEX IX_XepHang_ChuDeID ON XepHang(ChuDeID);
CREATE INDEX IX_XepHang_DoiChoiID ON XepHang(DoiChoiID);
GO
