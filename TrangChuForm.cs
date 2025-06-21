using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Đồ_án_1___Nhóm_14.CauHoi;

namespace Đồ_án_1___Nhóm_14
{
    public partial class TrangChuForm : Form
    {
        private List<CauHoi> cauHoi = new List<CauHoi>();

        public TrangChuForm()
        {
            InitializeComponent();
        }

        private void btnChonChuDe_Click(object sender, EventArgs e)
        {
            if (cauHoi.Count == 0)
            {
                string filePath = Application.StartupPath + @"\CauHoi.xlsx";
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Không tìm thấy file CauHoi.xlsx trong thư mục chương trình!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cauHoi = DoccauHoi(filePath);
            }

            var formChon = new ChonChuDeForm();
            if (formChon.ShowDialog() == DialogResult.OK)
            {
                string tenChuDe = formChon.ChuDeDuocChon;

                var danhSachTheoChuDe = (tenChuDe == "Ngẫu nhiên")
                    ? cauHoi
                    : cauHoi.Where(ch => ch.ChuDe.Trim() == tenChuDe).ToList();

                if (danhSachTheoChuDe.Count == 0)
                {
                    MessageBox.Show("Không có câu hỏi nào thuộc chủ đề này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var choiForm = new ChoiForm(danhSachTheoChuDe, tenChuDe);
                choiForm.ShowDialog();
            }
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

        public List<CauHoi> DoccauHoi(string filePath)
        {
            var mapChuDe = LayDanhSachChuDe();
            List<CauHoi> danhSach = new List<CauHoi>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var config = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration { UseHeaderRow = true }
                };
                var table = reader.AsDataSet(config).Tables[0];

                foreach (DataRow row in table.Rows)
                {
                    string chuDe = row["ChuDe"].ToString().Trim();
                    if (!mapChuDe.ContainsKey(chuDe)) continue;

                    string dapAnDung = row["DapAnDung"].ToString().Trim().ToUpper();
                    if (!new[] { "A", "B", "C", "D" }.Contains(dapAnDung)) continue;

                    CauHoi ch = new CauHoi
                    {
                        NoiDung = row["NoiDung"].ToString(),
                        DapAnA = row["DapAnA"].ToString(),
                        DapAnB = row["DapAnB"].ToString(),
                        DapAnC = row["DapAnC"].ToString(),
                        DapAnD = row["DapAnD"].ToString(),
                        DapAnDung = dapAnDung,
                        GiaiThich = row["GiaiThich"].ToString(),
                        ChuDe = chuDe,
                        ChuDeID = mapChuDe[chuDe]
                    };

                    danhSach.Add(ch);
                }
            }

            return danhSach;
        }

        private Dictionary<string, int> LayDanhSachChuDe()
        {
            var map = new Dictionary<string, int>();
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ID, TenChuDe FROM ChuDe", conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ten = reader["TenChuDe"].ToString().Trim();
                        int id = Convert.ToInt32(reader["ID"]);
                        map[ten] = id;
                    }
                }
            }
            return map;
        }
    }
}
