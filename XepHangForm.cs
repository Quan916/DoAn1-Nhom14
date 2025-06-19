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
            // Chuỗi kết nối
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True;";

            // Câu truy vấn dựa trên bảng XepHang hiện có
            string query = @"
                SELECT TOP 10 
                    Diem, 
                    ThoiGianTraLoi, 
                    ThoiGian 
                FROM XepHang 
                ORDER BY Diem DESC, ThoiGianTraLoi ASC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dgvDiemCao.DataSource = dt;

                        // Cập nhật tiêu đề cột cho dễ hiểu
                        dgvDiemCao.Columns["Diem"].HeaderText = "Điểm";
                        dgvDiemCao.Columns["ThoiGianTraLoi"].HeaderText = "TG trả lời (giây)";
                        dgvDiemCao.Columns["ThoiGian"].HeaderText = "Thời gian chơi";
                    }
                    else
                    {
                        dgvDiemCao.DataSource = null;
                        dgvDiemCao.Columns.Clear();
                        dgvDiemCao.Rows.Clear();
                        dgvDiemCao.Columns.Add("ThongBao", "Không có dữ liệu xếp hạng");
                        dgvDiemCao.Rows.Add("Chưa có người chơi nào.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
