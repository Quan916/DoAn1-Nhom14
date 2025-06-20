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

        private void btnLichSu_Click(object sender, EventArgs e) => Chon("Lịch sử");
        private void btnKhoaHoc_Click(object sender, EventArgs e) => Chon("Khoa học");
        private void btnDiaLy_Click(object sender, EventArgs e) => Chon("Địa lý");
        private void btnTheThao_Click(object sender, EventArgs e) => Chon("Thể thao");
        private void btnAmNhac_Click(object sender, EventArgs e) => Chon("Âm nhạc");
        private void btnCongNghe_Click(object sender, EventArgs e) => Chon("Công nghệ");
        private void btnVanHoc_Click(object sender, EventArgs e) => Chon("Văn học");
        private void btnTheGioi_Click(object sender, EventArgs e) => Chon("Thế giới");
        private void btnHoaHoc_Click(object sender, EventArgs e) => Chon("Hóa học");
        private void btnNgauNhien_Click(object sender, EventArgs e) => Chon("Ngẫu nhiên");
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Chon(string chuDe)
        {
            ChuDeDuocChon = chuDe;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}