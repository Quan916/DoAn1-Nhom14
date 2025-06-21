USE DoVuiKienThuc;
GO

CREATE VIEW vw_XepHangChiTiet AS
SELECT 
    ROW_NUMBER() OVER (ORDER BY XH.Diem DESC, XH.ThoiGianTraLoi ASC) AS STT,
    CH.TenChuDe,
    XH.Diem,
    XH.ThoiGianTraLoi,
    XH.ThoiGian
FROM XepHang AS XH
LEFT JOIN ChuDe AS CH ON XH.ChuDeID = CH.ID;
GO
