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

namespace Đồ_án_1___Nhóm_14
{
    public partial class XepHangForm : Form
    {
        public XepHangForm()
        {
            InitializeComponent();
            LoadDiemCao();
        }

        private void LoadDiemCao()
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        ROW_NUMBER() OVER (ORDER BY XH.Diem DESC, XH.ThoiGianTraLoi ASC) AS [STT],
                        CH.TenChuDe AS [Chủ đề],
                        XH.Diem AS [Điểm], 
                        XH.ThoiGianTraLoi AS [Thời gian (giây)], 
                        XH.ThoiGian AS [Thời gian ghi nhận]
                    FROM XepHang AS XH
                    LEFT JOIN ChuDe AS CH ON XH.ChuDeID = CH.ID
                ", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvXepHang.DataSource = dt;

                //dgvXepHang.Columns["STT"].HeaderText = "Thứ hạng";
                //dgvXepHang.Columns["Diem"].HeaderText = "Điểm";
                //dgvXepHang.Columns["ThoiGianTraLoi"].HeaderText = "Thời gian (giây)";
                //dgvXepHang.Columns["ThoiGian"].HeaderText = "Thời gian ghi nhận";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
