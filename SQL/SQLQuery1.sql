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

-- BẢNG ĐIỂM CAO
CREATE TABLE DiemCao (
    ID INT PRIMARY KEY IDENTITY(1,1),                        -- Khóa chính
    TenNguoiChoi NVARCHAR(100) NOT NULL,                     -- Không để trống tên
    Diem INT NOT NULL CHECK (Diem >= 0),                     -- Điểm ≥ 0
    ThoiGian DATETIME DEFAULT GETDATE()                      -- Tự động lấy thời gian hiện tại
);
GO
