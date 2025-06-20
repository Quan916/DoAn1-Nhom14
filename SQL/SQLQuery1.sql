USE DoVuiKienThuc;
GO

-- BẢNG CHỦ ĐỀ
CREATE TABLE ChuDe (
    ID INT PRIMARY KEY IDENTITY(1,1),                        -- Khóa chính
    TenChuDe NVARCHAR(100) NOT NULL
);
GO

-- Ràng buộc: Tên chủ đề là duy nhất
ALTER TABLE ChuDe 
ADD CONSTRAINT UQ_TenChuDe UNIQUE (TenChuDe);
GO

-- BẢNG CÂU HỎI
CREATE TABLE CauHoi (
    ID INT PRIMARY KEY IDENTITY(1,1),                        -- Khóa chính
    ChuDeID INT NOT NULL,                                    -- Khóa ngoại đến ChuDe
    NoiDung NVARCHAR(MAX) NOT NULL,                          -- Nội dung câu hỏi
    DapAnA NVARCHAR(255),
    DapAnB NVARCHAR(255),
    DapAnC NVARCHAR(255),
    DapAnD NVARCHAR(255),
    DapAnDung CHAR(1) 
        CHECK (DapAnDung IN ('A', 'B', 'C', 'D')) NOT NULL,  -- Ràng buộc chỉ nhận A/B/C/D
    GiaiThich NVARCHAR(MAX),                                 -- Giải thích đáp án
    CONSTRAINT FK_CauHoi_ChuDe 
        FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID) 
        ON DELETE CASCADE 
        ON UPDATE CASCADE
);
GO

-- BẢNG XẾP HẠNG
CREATE TABLE XepHang (
    ID INT PRIMARY KEY IDENTITY(1,1),                        -- Khóa chính
    Diem INT NOT NULL CHECK (Diem >= 0),                     -- Điểm đạt được
    ThoiGianTraLoi INT NOT NULL CHECK (ThoiGianTraLoi >= 0), -- Thời gian trả lời (giây)
    ThoiGian DATETIME DEFAULT GETDATE()                      -- Thời gian thực tế
);
GO

ALTER TABLE XepHang
ADD ChuDeID INT;
GO

ALTER TABLE XepHang
ADD CONSTRAINT FK_XepHang_ChuDe
    FOREIGN KEY (ChuDeID) REFERENCES ChuDe(ID)
    ON DELETE SET NULL
    ON UPDATE CASCADE;
GO

SELECT 
    XH.ID,
    CH.TenChuDe,
    XH.Diem,
    XH.ThoiGianTraLoi,
    XH.ThoiGian
FROM 
    XepHang AS XH
LEFT JOIN 
    ChuDe AS CH ON XH.ChuDeID = CH.ID
ORDER BY 
    XH.Diem DESC, 
    XH.ThoiGianTraLoi ASC;
GO
