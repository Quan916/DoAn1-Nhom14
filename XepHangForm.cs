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
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True;";

            string query = "SELECT TOP 10 TenNguoiChoi, Diem FROM DiemCao ORDER BY Diem DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDiemCao.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        // Tùy chọn: hiện thông báo trong DataGridView
                        dgvDiemCao.DataSource = null;
                        dgvDiemCao.Columns.Clear();
                        dgvDiemCao.Rows.Clear();
                        dgvDiemCao.Columns.Add("ThongBao", "Không có dữ liệu xếp hạng");
                        dgvDiemCao.Rows.Add("Chưa có người chơi nào.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
