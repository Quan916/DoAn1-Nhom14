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
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        string dapAnDung = "";
        string giaiThich = "";
        int diem = 0;
        int chuDeID;

        private int thoiGianConLai;

        public ChoiForm(int idChuDe)
        {
            InitializeComponent();
            chuDeID = idChuDe;
            conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DoVuiKienThuc;Integrated Security=True");
            LoadCauHoi();
        }

        private void LoadCauHoi()
        {
            try
            {
                conn.Open();

                if (chuDeID == -1)
                {
                    // Lấy ngẫu nhiên câu hỏi từ tất cả chủ đề
                    cmd = new SqlCommand("sp_LayCauHoiNgauNhien", conn);
                }
                else
                {
                    // Lấy câu hỏi theo chủ đề được chọn
                    cmd = new SqlCommand("sp_LayCauHoiNgauNhienTheoChuDe", conn);
                    cmd.Parameters.AddWithValue("@ChuDeID", chuDeID);
                }

                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lblCauHoi.Text = reader["NoiDung"].ToString();
                    btnDapAnA.Text = "A. " + reader["DapAnA"].ToString();
                    btnDapAnB.Text = "B. " + reader["DapAnB"].ToString();
                    btnDapAnC.Text = "C. " + reader["DapAnC"].ToString();
                    btnDapAnD.Text = "D. " + reader["DapAnD"].ToString();
                    dapAnDung = reader["DapAnDung"].ToString().Trim();
                    giaiThich = reader["GiaiThich"].ToString();
                }

                reader.Close();
                conn.Close();

                // Reset thời gian mỗi câu
                thoiGianConLai = 30;
                lblThoiGian.Text = "30s";
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải câu hỏi: " + ex.Message);
            }
        }

        private void KiemTraDapAn(string dapAnNguoiChon)
        {
            timer1.Stop(); // Dừng đếm thời gian sau khi chọn

            if (dapAnNguoiChon == dapAnDung)
            {
                diem += 1;
                MessageBox.Show("🎉 Chính xác!\n+10 điểm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"❌ Sai rồi!\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCauHoi();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGianConLai--;
            lblThoiGian.Text = thoiGianConLai + "s";

            if (thoiGianConLai == 0)
            {
                timer1.Stop();
                MessageBox.Show($"⏰ Hết giờ!\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Hết thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadCauHoi();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show($"🎯 Tổng điểm của bạn là: {diem}", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
