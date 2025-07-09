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
    public partial class XepHangForm : BaseForm
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

                // Cá nhân
                SqlDataAdapter daCaNhan = new SqlDataAdapter(@"
            SELECT ROW_NUMBER() OVER (ORDER BY Diem DESC, ThoiGianTraLoi ASC) AS [STT],
                   TenChuDe AS [Chủ đề],
                   Diem AS [Điểm],
                   ThoiGianTraLoi AS [Thời gian (giây)],
                   ThoiGian AS [Thời gian ghi nhận]
            FROM vw_XepHangChiTiet
            WHERE TenDoi IS NULL", conn);

                DataTable dtCaNhan = new DataTable();
                daCaNhan.Fill(dtCaNhan);
                dgvCaNhan.DataSource = dtCaNhan;

                // Đội nhóm
                SqlDataAdapter daDoi = new SqlDataAdapter(@"
            SELECT TenDoi AS [Đội chơi],
                   MAX(Diem) AS [Điểm cao nhất],
                   AVG(Diem) AS [Điểm trung bình],
                   COUNT(*) AS [Lượt chơi]
            FROM vw_XepHangChiTiet
            WHERE TenDoi IS NOT NULL
            GROUP BY TenDoi", conn);

                DataTable dtNhom = new DataTable();
                daDoi.Fill(dtNhom);
                dgvNhom.DataSource = dtNhom;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ bảng xếp hạng?", "Xác nhận xoá",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM XepHang", conn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đã xoá toàn bộ xếp hạng.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDiemCao();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}