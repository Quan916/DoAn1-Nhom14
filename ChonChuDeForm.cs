using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class ChonChuDeForm : Form
    {
        public string ChuDeDuocChon { get; private set; } = "";

        public ChonChuDeForm()
        {
            InitializeComponent();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Lịch sử";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Khoa học";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDiaLy_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Địa lý";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTheThao_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Thể thao";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAmNhac_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Âm nhạc";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCongNghe_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Công nghệ";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnVanHoc_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Văn học";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTheGioi_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Thế giới";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHoaHoc_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Hóa học";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNgauNhien_Click(object sender, EventArgs e)
        {
            ChuDeDuocChon = "Ngẫu nhiên";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
