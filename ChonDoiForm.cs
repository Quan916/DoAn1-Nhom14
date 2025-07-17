using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class ChonDoiForm : BaseForm
    {
        private readonly Dictionary<string, int> doiChoiMap = new Dictionary<string, int>();
        public int? DoiChoiID { get; private set; } = null;
        private readonly List<CauHoi> cauHoi;

        public ChonDoiForm(List<CauHoi> danhSachCauHoi)
        {
            InitializeComponent();
            cauHoi = danhSachCauHoi;
            LoadDanhSachDoi();
        }

        private void LoadDanhSachDoi()
        {
            var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand("SELECT ID, TenDoi FROM DoiChoi", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string ten = reader["TenDoi"].ToString();
                int id = (int)reader["ID"];
                cboDoiCoSan.Items.Add(ten);
                doiChoiMap[ten] = id;
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

            if (doiChoiMap.ContainsKey(tenDoi))
            {
                MessageBox.Show("Tên đội đã tồn tại, vui lòng nhập tên khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var conn = new SqlConnection(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand("INSERT INTO DoiChoi (TenDoi) OUTPUT INSERTED.ID VALUES (@TenDoi)", conn);
            cmd.Parameters.AddWithValue("@TenDoi", tenDoi);
            DoiChoiID = (int)cmd.ExecuteScalar();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnChoi_Click(object sender, EventArgs e)
        {
            if (cboDoiCoSan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đội chơi hoặc tạo mới đội.");
                return;
            }

            string ten = cboDoiCoSan.SelectedItem.ToString();
            DoiChoiID = doiChoiMap[ten];

            var chonChuDeForm = new ChonChuDeForm { Size = Size, Location = Location };
            if (chonChuDeForm.ShowDialog() != DialogResult.OK) return;

            string tenChuDe = chonChuDeForm.ChuDeDuocChon;
            var danhSachTheoChuDe = tenChuDe == "Ngẫu nhiên"
                ? cauHoi
                : cauHoi.Where(ch => ch.ChuDe.Trim().Equals(tenChuDe.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

            if (!danhSachTheoChuDe.Any())
            {
                MessageBox.Show("Không có câu hỏi nào cho chủ đề này.");
                return;
            }

            var choiForm = new ChoiForm(danhSachTheoChuDe, tenChuDe, DoiChoiID);
            choiForm.ShowDialog();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
