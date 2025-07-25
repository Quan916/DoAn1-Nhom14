﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace Đồ_án_1___Nhóm_14
{
    public partial class ChoiForm : BaseForm
    {
        private List<CauHoi> danhSachCauHoi;
        private int cauHoiHienTai = 0;
        private int diem = 0;
        private double thoiGianConLaiDouble;
        private string dapAnDung = "";
        private string giaiThich = "";
        private Random rand = new Random();
        private DateTime thoiGianBatDau;
        private string tenChuDe;
        private int? doiChoiID;

        private readonly string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";

        public ChoiForm(List<CauHoi> cauHoiExcel, string chuDeDuocChon, int? doiChoiID)
        {
            InitializeComponent();
            danhSachCauHoi = cauHoiExcel.OrderBy(x => rand.Next()).ToList();
            thoiGianBatDau = DateTime.Now;
            tenChuDe = chuDeDuocChon.Trim();
            this.doiChoiID = doiChoiID;

            diem = 0;
            CapNhatThongTinHeader();
            LoadCauHoi();
        }

        private void ChoiForm_Load(object sender, EventArgs e)
        {
            MediaPlayerManager.Init();
        }

        private void LoadCauHoi()
        {
            if (cauHoiHienTai >= danhSachCauHoi.Count)
            {
                timer1.Stop();
                KetThucGame(true);
                return;
            }

            var ch = danhSachCauHoi[cauHoiHienTai];
            lblCauHoi.Text = ch.NoiDung;
            btnDapAnA.Text = "A. " + ch.DapAnA;
            btnDapAnB.Text = "B. " + ch.DapAnB;
            btnDapAnC.Text = "C. " + ch.DapAnC;
            btnDapAnD.Text = "D. " + ch.DapAnD;
            dapAnDung = ch.DapAnDung.Trim().ToUpper();
            giaiThich = ch.GiaiThich;

            thoiGianConLaiDouble = 30.0;
            lblThoiGian.Text = "30.0s";
            progressThoiGian.Value = 300;

            DatTrangThaiNutDapAn(true);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGianConLaiDouble -= 0.1;
            if (thoiGianConLaiDouble < 0) thoiGianConLaiDouble = 0;

            lblThoiGian.Text = $"{thoiGianConLaiDouble:F1}s";
            progressThoiGian.Value = (int)(thoiGianConLaiDouble * 10);

            if (thoiGianConLaiDouble <= 0)
            {
                timer1.Stop();
                DatTrangThaiNutDapAn(false);
                ThongBaoKetThuc("⏰ Hết giờ!");
            }
        }

        private void KiemTraDapAn(string dapAnNguoiChon)
        {
            timer1.Stop();
            DatTrangThaiNutDapAn(false);

            if (dapAnNguoiChon == dapAnDung)
            {
                PhatAmThanh("correct.mp3");
                diem += 10;
                MessageBox.Show("✅ Chính xác!\n+10 điểm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cauHoiHienTai++;
                CapNhatThongTinHeader();
                LoadCauHoi();
            }
            else
            {
                PhatAmThanh("wrong.mp3");
                ThongBaoKetThuc("❌ Sai rồi!");
            }
        }

        private void ThongBaoKetThuc(string message)
        {
            MessageBox.Show($"{message}\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            KetThucGame();
        }

        private void KetThucGame(bool hoanThanhHet = false)
        {
            int tongThoiGian = (int)(DateTime.Now - thoiGianBatDau).TotalSeconds;
            LuuDiem(diem, tongThoiGian, doiChoiID);

            var msg = hoanThanhHet ?
                $"🎉 Bạn đã hoàn thành tất cả câu hỏi!\nTổng điểm: {diem}" :
                $"🎯 Trò chơi kết thúc!\nTổng điểm của bạn: {diem}";

            var choiLai = MessageBox.Show($"{msg}\n\nBạn có muốn chơi lại không?", "Chơi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choiLai == DialogResult.Yes)
            {
                cauHoiHienTai = 0;
                diem = 0;
                CapNhatThongTinHeader();
                danhSachCauHoi = danhSachCauHoi.OrderBy(x => rand.Next()).ToList();
                thoiGianBatDau = DateTime.Now;
                LoadCauHoi();
            }
            else this.Close();
        }

        private void CapNhatThongTinHeader()
        {
            int diemCaoNhat = LayDiemCaoNhatTheoChuDe(tenChuDe);
            lblChuDe.Text = $"Chủ đề: {tenChuDe}";
            lblDiemCao.Text = $"Điểm cao nhất: {diemCaoNhat}";
            lblDiem.Text = $"Điểm: {diem}";
        }

        private int LayDiemCaoNhatTheoChuDe(string tenChuDe)
        {
            if (tenChuDe == "Ngẫu nhiên") return 0;

            var conn = new SqlConnection(connStr);
            conn.Open();
            var cmd = new SqlCommand(@"SELECT MAX(X.Diem) FROM XepHang X JOIN ChuDe C ON X.ChuDeID = C.ID WHERE C.TenChuDe = @TenChuDe", conn);
            cmd.Parameters.AddWithValue("@TenChuDe", tenChuDe);

            var result = cmd.ExecuteScalar();
            return result != DBNull.Value ? Convert.ToInt32(result) : 0;
        }

        private void LuuDiem(int diem, int thoiGianTraLoi, int? doiChoiID)
        {
            int? chuDeID = tenChuDe == "Ngẫu nhiên" ? null : LayChuDeIDTuTen(tenChuDe);

            if (tenChuDe != "Ngẫu nhiên" && chuDeID == null)
            {
                MessageBox.Show("❌ Chủ đề '" + tenChuDe + "' không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            var conn = new SqlConnection(connStr);
            conn.Open();
            var cmd = new SqlCommand(@"INSERT INTO XepHang (Diem, ThoiGianTraLoi, ChuDeID, DoiChoiID) VALUES (@Diem, @ThoiGianTraLoi, @ChuDeID, @DoiChoiID)", conn);

            cmd.Parameters.AddWithValue("@Diem", diem);
            cmd.Parameters.AddWithValue("@ThoiGianTraLoi", thoiGianTraLoi);
            cmd.Parameters.AddWithValue("@ChuDeID", chuDeID.HasValue ? (object)chuDeID.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@DoiChoiID", doiChoiID.HasValue ? (object)doiChoiID.Value : DBNull.Value);

            cmd.ExecuteNonQuery();
        }

        private int? LayChuDeIDTuTen(string tenChuDe)
        {
            var conn = new SqlConnection(connStr);
            conn.Open();
            var cmd = new SqlCommand("SELECT ID FROM ChuDe WHERE TenChuDe = @TenChuDe", conn);
            cmd.Parameters.AddWithValue("@TenChuDe", tenChuDe);
            var result = cmd.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out int id))
                return id;
            return null;
        }

        private void btnLuatChoi_Click(object sender, EventArgs e)
        {
            string luat = "🎮 LUẬT CHƠI\n\n" +
                          "1. Chọn một chủ đề để bắt đầu.\n" +
                          "2. Mỗi câu có 30 giây để trả lời.\n" +
                          "3. Trả lời đúng: +10 điểm.\n" +
                          "4. Trả lời sai hoặc hết giờ: kết thúc game.\n" +
                          "5. Trò chơi kết thúc khi hết câu hỏi.\n\n" +
                          "Chúc bạn may mắn! 🍀";
            MessageBox.Show(luat, "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var form = new CaiDatAmThanhForm();
            form.ShowDialog(this);
        }

        private void btnDapAnA_Click(object sender, EventArgs e)
        {
            KiemTraDapAn("A");
        }

        private void btnDapAnB_Click(object sender, EventArgs e)
        {
            KiemTraDapAn("B");
        }

        private void btnDapAnC_Click(object sender, EventArgs e)
        {
            KiemTraDapAn("C");
        }

        private void btnDapAnD_Click(object sender, EventArgs e)
        {
            KiemTraDapAn("D");
        }

        private void DatTrangThaiNutDapAn(bool enabled)
        {
            btnDapAnA.Enabled = enabled;
            btnDapAnB.Enabled = enabled;
            btnDapAnC.Enabled = enabled;
            btnDapAnD.Enabled = enabled;
        }

        private void PhatAmThanh(string filePath)
        {
            if (Properties.Settings.Default.EffectVolume == 0 || !System.IO.File.Exists(filePath)) return;

            try
            {
                var reader = new AudioFileReader(filePath)
                {
                    Volume = Properties.Settings.Default.EffectVolume / 100f
                };

                var output = new WaveOutEvent();
                output.Init(reader);
                output.Play();

                output.PlaybackStopped += (s, e) =>
                {
                    output.Dispose();
                    reader.Dispose();
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi phát âm thanh {filePath}: {ex.Message}");
            }
        }
    }
}
