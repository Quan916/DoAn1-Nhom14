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
    public partial class ChonDoiForm : Form
    {
        private Dictionary<string, int> doiChoiMap = new Dictionary<string, int>();
        public int? DoiChoiID { get; private set; } = null;

        public ChonDoiForm()
        {
            InitializeComponent();
            LoadDanhSachDoi();
        }

        private void LoadDanhSachDoi()
        {
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, TenDoi FROM DoiChoi", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string ten = reader["TenDoi"].ToString();
                    int id = (int)reader["ID"];
                    cboDoiCoSan.Items.Add(ten);
                    doiChoiMap[ten] = id;
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            string tenDoi = txtTenDoi.Text.Trim();
            if (string.IsNullOrEmpty(tenDoi))
            {
                MessageBox.Show("Tên đội không được để trống!");
                return;
            }

            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO DoiChoi (TenDoi) OUTPUT INSERTED.ID VALUES (@TenDoi)", conn);
                cmd.Parameters.AddWithValue("@TenDoi", tenDoi);
                int id = (int)cmd.ExecuteScalar();
                DoiChoiID = id;
                DialogResult = DialogResult.OK;
                this.Close();
            }

            if (doiChoiMap.ContainsKey(tenDoi))
            {
                MessageBox.Show("Tên đội đã tồn tại, vui lòng nhập tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            if (cboDoiCoSan.SelectedItem != null)
            {
                string ten = cboDoiCoSan.SelectedItem.ToString();
                DoiChoiID = doiChoiMap[ten];
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đội chơi hoặc tạo mới đội.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}