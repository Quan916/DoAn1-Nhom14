using ExcelDataReader;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class TrangChuForm : BaseForm
    {
        private List<CauHoi> cauHoi = new List<CauHoi>();
        private int? doiChoiID = null;

        public TrangChuForm()
        {
            InitializeComponent();
            Resize += (s, e) => CenterControls();
        }

        private void TrangChuForm_Load(object sender, EventArgs e)
        {
            MediaPlayerManager.Init();
            string filePath = Path.Combine(Application.StartupPath, "CauHoi.xlsx");

            if (File.Exists(filePath))
                cauHoi = DoccauHoi(filePath);
            else
                MessageBox.Show("Không tìm thấy file câu hỏi Excel!");
        }

        private void CenterControls()
        {
            lblTieuDe.Width = ClientSize.Width;
            buttonPanel.Location = new Point((ClientSize.Width - buttonPanel.Width) / 2, buttonPanel.Location.Y);
            btnThoat.Location = new Point((ClientSize.Width - btnThoat.Width) / 2, ClientSize.Height - btnThoat.Height - 40);
        }

        private void btnChonChuDe_Click(object sender, EventArgs e)
        {
            Hide();
            var chonChuDeForm = new ChonChuDeForm { Size = Size, Location = Location, StartPosition = FormStartPosition.Manual };
            if (chonChuDeForm.ShowDialog() == DialogResult.OK)
            {
                string tenChuDe = chonChuDeForm.ChuDeDuocChon;
                var danhSachTheoChuDe = tenChuDe == "Ngẫu nhiên"
                    ? cauHoi
                    : cauHoi.Where(ch => ch.ChuDe.Trim().Equals(tenChuDe.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (!danhSachTheoChuDe.Any())
                {
                    MessageBox.Show("Không có câu hỏi nào.");
                    Show();
                    return;
                }

                new ChoiForm(danhSachTheoChuDe, tenChuDe, doiChoiID).ShowDialog();
            }
            Show();
        }

        private void btnBangXepHang_Click(object sender, EventArgs e) => new XepHangForm { Size = Size, Location = Location, StartPosition = FormStartPosition.Manual }.ShowDialog();

        private void btnSetting_Click(object sender, EventArgs e) => new CaiDatAmThanhForm().ShowDialog(this);

        private void btnChonDoi_Click(object sender, EventArgs e)
        {
            var form = new ChonDoiForm(cauHoi) { Size = Size, Location = Location, StartPosition = FormStartPosition.Manual };
            form.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e) => Application.Exit();

        public List<CauHoi> DoccauHoi(string filePath)
        {
            List<CauHoi> danhSach = new List<CauHoi>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var chuDeMap = LayDanhSachChuDe();

            var stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var config = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration { UseHeaderRow = true }
            };

            var table = reader.AsDataSet(config).Tables[0];
            foreach (DataRow row in table.Rows)
            {
                string chuDe = row["ChuDe"].ToString().Trim();
                string dapAnDung = row["DapAnDung"].ToString().Trim().ToUpper();
                if (!new[] { "A", "B", "C", "D" }.Contains(dapAnDung)) continue;

                int chuDeID = chuDeMap.TryGetValue(chuDe, out var id) ? id : 0;
                danhSach.Add(new CauHoi
                {
                    NoiDung = row["NoiDung"].ToString(),
                    DapAnA = row["DapAnA"].ToString(),
                    DapAnB = row["DapAnB"].ToString(),
                    DapAnC = row["DapAnC"].ToString(),
                    DapAnD = row["DapAnD"].ToString(),
                    DapAnDung = dapAnDung,
                    GiaiThich = row["GiaiThich"].ToString(),
                    ChuDe = chuDe,
                    ChuDeID = chuDeID
                });
            }
            return danhSach;
        }

        private Dictionary<string, int> LayDanhSachChuDe()
        {
            var map = new Dictionary<string, int>();
            var conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DoVuiKienThuc;Integrated Security=True");
            conn.Open();
            var cmd = new SqlCommand("SELECT ID, TenChuDe FROM ChuDe", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string ten = reader["TenChuDe"].ToString().Trim();
                int id = Convert.ToInt32(reader["ID"]);
                map[ten] = id;
            }
            return map;
        }
    }
}
