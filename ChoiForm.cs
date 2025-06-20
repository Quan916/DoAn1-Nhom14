using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Đồ_án_1___Nhóm_14
{
    public partial class ChoiForm : Form
    {
        private List<CauHoi> danhSachCauHoi;
        private int cauHoiHienTai = 0;
        private int diem = 0;
        private int thoiGianConLai;
        private string dapAnDung = "";
        private string giaiThich = "";
        private Random rand = new Random();

        public ChoiForm(List<CauHoi> cauHoiExcel)
        {
            InitializeComponent();
            HienThiLuatChoi();
            danhSachCauHoi = cauHoiExcel.OrderBy(x => rand.Next()).ToList();
            LoadCauHoi();
        }

        private void LoadCauHoi()
        {
            if (cauHoiHienTai >= danhSachCauHoi.Count)
            {
                timer1.Stop();
                MessageBox.Show($"🎉 Bạn đã hoàn thành tất cả câu hỏi!\nTổng điểm: {diem}", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                int tongThoiGian = danhSachCauHoi.Count * 30;
                int chuDeID = danhSachCauHoi[0].ChuDeID;

                LuuKetQua(diem, tongThoiGian, chuDeID);

                this.Close();
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
                lblDiem.Text = "Điểm: " + diem;
                MessageBox.Show("✅ Chính xác!\n+10 điểm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cauHoiHienTai++;
                LoadCauHoi();
            }
            else
            {
                MessageBox.Show($"❌ Sai rồi!\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Sai rồi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show($"🎯 Trò chơi kết thúc!\nTổng điểm của bạn: {diem}", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int tongThoiGian = cauHoiHienTai * 30 + (30 - thoiGianConLai);
                int chuDeID = danhSachCauHoi[0].ChuDeID;

                LuuKetQua(diem, tongThoiGian, chuDeID);

                this.Close();
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

                int tongThoiGian = cauHoiHienTai * 30 + 30;
                int chuDeID = danhSachCauHoi[0].ChuDeID;

                LuuKetQua(diem, tongThoiGian, chuDeID);

                MessageBox.Show($"🎯 Trò chơi kết thúc!\nTổng điểm của bạn: {diem}", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private void btnDapAnA_Click(object sender, EventArgs e) => KiemTraDapAn("A");
        private void btnDapAnB_Click(object sender, EventArgs e) => KiemTraDapAn("B");
        private void btnDapAnC_Click(object sender, EventArgs e) => KiemTraDapAn("C");
        private void btnDapAnD_Click(object sender, EventArgs e) => KiemTraDapAn("D");

        private void btnThoat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show($"🎯 Tổng điểm của bạn là: {diem}", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void HienThiLuatChoi()
        {
            string luat = "🎮 LUẬT CHƠI\n\n" +
                          "1. Chọn một chủ đề để bắt đầu.\n" +
                          "2. Mỗi câu có 30 giây để trả lời.\n" +
                          "3. Trả lời đúng: +10 điểm.\n" +
                          "4. Trả lời sai: Trò chơi kết thúc ngay.\n" +
                          "5. Trò chơi kết thúc khi hết câu hỏi.\n\n" +
                          "Chúc bạn may mắn! 🍀";

            MessageBox.Show(luat, "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LuuKetQua(int diem, int thoiGianTraLoi, int chuDeID)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO XepHang (Diem, ThoiGianTraLoi, ChuDeID) " +
                               "VALUES (@Diem, @ThoiGianTraLoi, @ChuDeID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Diem", diem);
                    cmd.Parameters.AddWithValue("@ThoiGianTraLoi", thoiGianTraLoi);
                    cmd.Parameters.AddWithValue("@ChuDeID", chuDeID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
