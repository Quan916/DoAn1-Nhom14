using ExcelDataReader;
using FontAwesome.Sharp;
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
    public partial class TrangChuForm : BaseForm
    {
        private List<CauHoi> cauHoi = new List<CauHoi>();
        private TrackBar trackVolume;
        private Button btnToggleLoop;
        private Button btnChonNhac;
        private int? doiChoiID = null;

        public TrangChuForm()
        {
            InitializeComponent();
            this.Resize += TrangChuForm_Resize;
        }

        private void TrangChuForm_Load(object sender, EventArgs e)
        {
            MediaPlayerManager.Init(axWMP);

            string filePath = Path.Combine(Application.StartupPath, "CauHoi.xlsx");
            if (File.Exists(filePath))
            {
                cauHoi = DoccauHoi(filePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file câu hỏi Excel!");
            }
        }

        private void TrangChuForm_Resize(object sender, EventArgs e)
        {
            CenterControls();
        }

        private void CenterControls()
        {
            if (lblTieuDe != null)
                lblTieuDe.Width = this.ClientSize.Width;

            if (buttonPanel != null)
                buttonPanel.Location = new Point((this.ClientSize.Width - buttonPanel.Width) / 2, buttonPanel.Location.Y);

            if (btnThoat != null)
                btnThoat.Location = new Point((this.ClientSize.Width - btnThoat.Width) / 2, this.ClientSize.Height - btnThoat.Height - 40);
        }

        private void btnChonChuDe_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ChonChuDeForm = new ChonChuDeForm { Size = this.Size, Location = this.Location, StartPosition = FormStartPosition.Manual };
            if (ChonChuDeForm.ShowDialog() == DialogResult.OK)
            {
                string tenChuDe = ChonChuDeForm.ChuDeDuocChon;
                var danhSachTheoChuDe = tenChuDe == "Ngẫu nhiên" ? cauHoi : cauHoi.Where(ch => ch.ChuDe.Trim().Equals(tenChuDe.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();

                if (danhSachTheoChuDe.Count == 0)
                {
                    MessageBox.Show("Không có câu hỏi nào.");
                    this.Show();
                    return;
                }

                var choiForm = new ChoiForm(danhSachTheoChuDe, tenChuDe, doiChoiID);
                choiForm.ShowDialog();
            }
            this.Show();
        }

        private void btnBangXepHang_Click(object sender, EventArgs e)
        {
            var XepHangForm = new XepHangForm { Size = this.Size, Location = this.Location, StartPosition = FormStartPosition.Manual };
            XepHangForm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form popup = new Form { Text = "Cài đặt âm thanh", FormBorderStyle = FormBorderStyle.FixedDialog, StartPosition = FormStartPosition.CenterParent, ClientSize = new Size(240, 200) };
            trackVolume = new TrackBar { Location = new Point(30, 20), Maximum = 100, Value = Properties.Settings.Default.Volume };
            trackVolume.Scroll += (s, ev) => MediaPlayerManager.SetVolume(trackVolume.Value);

            btnToggleLoop = new Button { Text = Properties.Settings.Default.IsLoop ? "🔁 Lặp: BẬT" : "⏹️ Lặp: TẮT", Size = new Size(150, 30), Location = new Point(30, 70) };
            btnToggleLoop.Click += (s, ev) => {
                MediaPlayerManager.ToggleLoop();
                btnToggleLoop.Text = Properties.Settings.Default.IsLoop ? "🔁 Lặp: BẬT" : "⏹️ Lặp: TẮT";
            };

            btnChonNhac = new Button { Text = "🎵 Chọn nhạc", Size = new Size(150, 30), Location = new Point(30, 120) };
            btnChonNhac.Click += (s, ev) =>
            {
                Form chonNhacForm = new Form { Text = "Chọn nhạc nền", Size = new Size(300, 180), StartPosition = FormStartPosition.CenterParent, FormBorderStyle = FormBorderStyle.FixedDialog };
                Label lbl = new Label { Text = "🎵 Chọn nhạc nền:", Location = new Point(20, 20), AutoSize = true };
                ComboBox cboNhac = new ComboBox { Location = new Point(20, 50), Size = new Size(240, 25), DropDownStyle = ComboBoxStyle.DropDownList };

                string musicFolder = Path.Combine(Application.StartupPath, "Music");
                if (!Directory.Exists(musicFolder)) Directory.CreateDirectory(musicFolder);
                foreach (var file in Directory.GetFiles(musicFolder, "*.mp3")) cboNhac.Items.Add(Path.GetFileName(file));
                if (cboNhac.Items.Count > 0) cboNhac.SelectedIndex = 0;

                Button btnOK = new Button { Text = "▶️ Phát", Location = new Point(100, 90), DialogResult = DialogResult.OK };
                chonNhacForm.Controls.Add(lbl);
                chonNhacForm.Controls.Add(cboNhac);
                chonNhacForm.Controls.Add(btnOK);
                chonNhacForm.AcceptButton = btnOK;

                if (chonNhacForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = Path.Combine(musicFolder, cboNhac.SelectedItem.ToString());
                    MediaPlayerManager.ChangeMusic(selectedFile);
                }
            };

            popup.Controls.Add(trackVolume);
            popup.Controls.Add(btnToggleLoop);
            popup.Controls.Add(btnChonNhac);
            popup.ShowDialog();
        }

        private void btnChonDoi_Click(object sender, EventArgs e)
        {
            var form = new ChonDoiForm(cauHoi)  // ✅ truyền danh sách câu hỏi
            {
                Size = this.Size,
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };

            form.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public List<CauHoi> DoccauHoi(string filePath)
        {
            List<CauHoi> danhSach = new List<CauHoi>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var chuDeMap = LayDanhSachChuDe();

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
                    string dapAnDung = row["DapAnDung"].ToString().Trim().ToUpper();

                    if (!new[] { "A", "B", "C", "D" }.Contains(dapAnDung)) continue;

                    int chuDeID = chuDeMap.ContainsKey(chuDe) ? chuDeMap[chuDe] : 0;

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
                        ChuDeID = chuDeID // ✅ đã gán đúng từ DB
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