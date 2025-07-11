using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class ChoiForm : BaseForm
    {
        private List<CauHoi> danhSachCauHoi;
        private int cauHoiHienTai = 0;
        private int diem = 0;
        private int thoiGianConLai;
        private string dapAnDung = "";
        private string giaiThich = "";
        private Random rand = new Random();
        private DateTime thoiGianBatDau;
        private string tenChuDe;
        private int? doiChoiID;

        private string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";

        public ChoiForm(List<CauHoi> cauHoiExcel, string chuDeDuocChon, int? doiChoiID)
        {
            InitializeComponent();

            danhSachCauHoi = cauHoiExcel.OrderBy(x => rand.Next()).ToList();
            thoiGianBatDau = DateTime.Now;
            tenChuDe = chuDeDuocChon.Trim();
            this.doiChoiID = doiChoiID;

            diem = 0;
            CapNhatDiem();
            LoadCauHoi();
        }

        private void LoadCauHoi()
        {
            if (cauHoiHienTai >= danhSachCauHoi.Count)
            {
                timer1.Stop();
                int tongThoiGian = (int)(DateTime.Now - thoiGianBatDau).TotalSeconds;
                LuuDiem(diem, tongThoiGian, doiChoiID);

                var choiLai = MessageBox.Show($"🎉 Bạn đã hoàn thành tất cả câu hỏi!\nTổng điểm: {diem}\n\nBạn có muốn chơi lại không?",
                    "Chơi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choiLai == DialogResult.Yes)
                {
                    cauHoiHienTai = 0;
                    diem = 0;
                    CapNhatDiem();
                    danhSachCauHoi = danhSachCauHoi.OrderBy(x => rand.Next()).ToList();
                    thoiGianBatDau = DateTime.Now;
                    LoadCauHoi();
                }
                else this.Close();
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

            thoiGianConLai = 30;
            lblThoiGian.Text = "30s";
            timer1.Start();
        }

        private void KiemTraDapAn(string dapAnNguoiChon)
        {
            timer1.Stop();

            if (dapAnNguoiChon == dapAnDung)
            {
                diem += 10;
                CapNhatDiem();
                MessageBox.Show("✅ Chính xác!\n+10 điểm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cauHoiHienTai++;
                LoadCauHoi();
            }
            else
            {
                MessageBox.Show($"❌ Sai rồi!\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Sai rồi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int tongThoiGian = (int)(DateTime.Now - thoiGianBatDau).TotalSeconds;
                LuuDiem(diem, tongThoiGian, doiChoiID);

                var choiLai = MessageBox.Show($"🎯 Trò chơi kết thúc!\nTổng điểm của bạn: {diem}\n\nBạn có muốn chơi lại không?",
                    "Chơi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choiLai == DialogResult.Yes)
                {
                    cauHoiHienTai = 0;
                    diem = 0;
                    CapNhatDiem();
                    danhSachCauHoi = danhSachCauHoi.OrderBy(x => rand.Next()).ToList();
                    thoiGianBatDau = DateTime.Now;
                    LoadCauHoi();
                }
                else this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGianConLai--;
            lblThoiGian.Text = thoiGianConLai + "s";

            if (thoiGianConLai == 0)
            {
                timer1.Stop();
                MessageBox.Show($"⏰ Hết giờ!\nĐáp án đúng: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Hết thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                int tongThoiGian = (int)(DateTime.Now - thoiGianBatDau).TotalSeconds;
                LuuDiem(diem, tongThoiGian, doiChoiID);

                var choiLai = MessageBox.Show($"🎯 Trò chơi kết thúc!\nTổng điểm của bạn: {diem}\n\nBạn có muốn chơi lại không?",
                    "Chơi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choiLai == DialogResult.Yes)
                {
                    cauHoiHienTai = 0;
                    diem = 0;
                    CapNhatDiem();
                    danhSachCauHoi = danhSachCauHoi.OrderBy(x => rand.Next()).ToList();
                    thoiGianBatDau = DateTime.Now;
                    LoadCauHoi();
                }
                else this.Close();
            }
        }

        private void LuuDiem(int diem, int thoiGianTraLoi, int? doiChoiID)
        {
            int? chuDeID = tenChuDe == "Ngẫu nhiên" ? null : LayChuDeIDTuTen(tenChuDe);

            if (tenChuDe != "Ngẫu nhiên" && chuDeID == null)
            {
                MessageBox.Show("❌ Chủ đề '" + tenChuDe + "' không tồn tại trong cơ sở dữ liệu!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            INSERT INTO XepHang (Diem, ThoiGianTraLoi, ChuDeID, DoiChoiID)
            VALUES (@Diem, @ThoiGianTraLoi, @ChuDeID, @DoiChoiID)", conn);

                cmd.Parameters.AddWithValue("@Diem", diem);
                cmd.Parameters.AddWithValue("@ThoiGianTraLoi", thoiGianTraLoi);
                cmd.Parameters.AddWithValue("@ChuDeID", chuDeID.HasValue ? (object)chuDeID.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@DoiChoiID", doiChoiID.HasValue ? (object)doiChoiID.Value : DBNull.Value);

                cmd.ExecuteNonQuery();
            }
        }

        private void btnDapAnA_Click(object sender, EventArgs e) => KiemTraDapAn("A");
        private void btnDapAnB_Click(object sender, EventArgs e) => KiemTraDapAn("B");
        private void btnDapAnC_Click(object sender, EventArgs e) => KiemTraDapAn("C");
        private void btnDapAnD_Click(object sender, EventArgs e) => KiemTraDapAn("D");

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

        private void CapNhatDiem()
        {
            lblDiem.Text = $"Chủ đề: {tenChuDe} | Điểm: {diem}";
        }

        private int? LayChuDeIDTuTen(string tenChuDe)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID FROM ChuDe WHERE TenChuDe = @TenChuDe", conn);
                cmd.Parameters.AddWithValue("@TenChuDe", tenChuDe);
                object result = cmd.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int chuDeID))
                {
                    return chuDeID;
                }
                return null;
            }
        }
    }
}
