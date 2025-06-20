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
        private Random rand = new Random();
        private int thoiGianConLai;
        private string dapAnDung = "";
        private string giaiThich = "";
        private int diem = 0;

        public ChoiForm(List<CauHoi> cauHoiExcel)
        {
            InitializeComponent();
            danhSachCauHoi = cauHoiExcel;
            LoadCauHoiExcel();
        }

        private void LoadCauHoiExcel()
        {
            if (danhSachCauHoi.Count == 0)
            {
                MessageBox.Show("Không có câu hỏi nào để chơi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            var ch = danhSachCauHoi[rand.Next(danhSachCauHoi.Count)];

            lblCauHoi.Text = ch.NoiDung;
            btnDapAnA.Text = "A. " + ch.DapAnA;
            btnDapAnB.Text = "B. " + ch.DapAnB;
            btnDapAnC.Text = "C. " + ch.DapAnC;
            btnDapAnD.Text = "D. " + ch.DapAnD;
            dapAnDung = ch.DapAnDung.Trim();
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
                diem += 1;
                MessageBox.Show("🎉 Chính xác!\n+10 điểm", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"❌ Sai rồi!\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCauHoiExcel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            thoiGianConLai--;
            lblThoiGian.Text = thoiGianConLai + "s";

            if (thoiGianConLai == 0)
            {
                timer1.Stop();
                MessageBox.Show($"⏰ Hết giờ!\nĐáp án đúng là: {dapAnDung}\n\nGiải thích:\n{giaiThich}", "Hết thời gian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadCauHoiExcel();
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
    }
}
