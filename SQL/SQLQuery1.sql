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
    CONSTRAINT FK_CauHoi_ChuDe 
        FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);
GO

-- BẢNG XẾP HẠNG
CREATE TABLE XepHang (
    ID INT PRIMARY KEY IDENTITY(1,1),
    Diem INT NOT NULL CHECK (Diem >= 0),
    ThoiGianTraLoi INT NOT NULL CHECK (ThoiGianTraLoi >= 0),
    ThoiGian DATETIME DEFAULT GETDATE(),
    ChuDeID INT
);
GO

ALTER TABLE XepHang
ADD CONSTRAINT FK_XepHang_ChuDe
    FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
    ON DELETE SET NULL
    ON UPDATE CASCADE;
GO

-- THÊM DỮ LIỆU CHỦ ĐỀ MẪU
INSERT INTO ChuDe (TenChuDe) VALUES 
(N'Lịch sử'), (N'Khoa học'), (N'Địa lý'), (N'Thể thao'),
(N'Âm nhạc'), (N'Công nghệ'), (N'Văn học'), (N'Thế giới'), (N'Hóa học');
GO