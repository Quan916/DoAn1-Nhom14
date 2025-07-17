using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class XepHangForm : BaseForm
    {
        private readonly string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";

        public XepHangForm()
        {
            InitializeComponent();
            LoadDiemCao();
        }

        private void LoadDiemCao()
        {
            var conn = new SqlConnection(connStr);
            conn.Open();

            // Cá nhân
            var daCaNhan = new SqlDataAdapter(@"
                SELECT ROW_NUMBER() OVER (ORDER BY Diem DESC, ThoiGianTraLoi ASC) AS [STT],
                       TenChuDe AS [Chủ đề],
                       Diem AS [Điểm],
                       ThoiGianTraLoi AS [Thời gian (giây)],
                       ThoiGian AS [Thời gian ghi nhận]
                FROM vw_XepHangChiTiet
                WHERE TenDoi IS NULL", conn);
            var dtCaNhan = new DataTable();
            daCaNhan.Fill(dtCaNhan);
            dgvCaNhan.DataSource = dtCaNhan;

            // Đội nhóm
            var daDoi = new SqlDataAdapter(@"
                SELECT TenDoi AS [Đội chơi],
                       MAX(Diem) AS [Điểm cao nhất],
                       AVG(Diem) AS [Điểm trung bình],
                       COUNT(*) AS [Lượt chơi]
                FROM vw_XepHangChiTiet
                WHERE TenDoi IS NOT NULL
                GROUP BY TenDoi", conn);
            var dtNhom = new DataTable();
            daDoi.Fill(dtNhom);
            dgvNhom.DataSource = dtNhom;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ bảng xếp hạng?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var conn = new SqlConnection(connStr);
                conn.Open();
                new SqlCommand("DELETE FROM XepHang", conn).ExecuteNonQuery();

                MessageBox.Show("Đã xoá toàn bộ xếp hạng.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDiemCao();
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}
