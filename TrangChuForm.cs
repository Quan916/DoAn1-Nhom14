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
    public partial class TrangChuForm : Form
    {
        public TrangChuForm()
        {
            InitializeComponent();
        }

        private void btnChonChuDe_Click(object sender, EventArgs e)
        {
            ChonChuDeForm chonForm = new ChonChuDeForm();
            chonForm.ShowDialog();
        }

        private void btnBangXepHang_Click(object sender, EventArgs e)
        {
            XepHangForm diemForm = new XepHangForm();
            diemForm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
