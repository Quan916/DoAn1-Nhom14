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
        private TrackBar trackVolume;
        private Button btnToggleLoop;
        private Button btnChonNhac;
        private int? doiChoiID = null;

        public TrangChuForm()
        {
            InitializeComponent();
        }

        private void TrangChuForm_Load(object sender, EventArgs e)
        {
            MediaPlayerManager.Init(axWMP);
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
                    : cauHoi.Where(ch => string.Equals(ch.ChuDe.Trim(), tenChuDe.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();


                if (danhSachTheoChuDe.Count == 0)
                {
                    MessageBox.Show("Không có câu hỏi nào thuộc chủ đề này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var choiForm = new ChoiForm(danhSachTheoChuDe, tenChuDe, doiChoiID);
                choiForm.ShowDialog();
            }
        }

        private void btnBangXepHang_Click(object sender, EventArgs e)
        {
            XepHangForm diemForm = new XepHangForm();
            diemForm.ShowDialog();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Form popup = new Form();
            popup.Text = "Cài đặt âm thanh";
            popup.FormBorderStyle = FormBorderStyle.FixedDialog;
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ClientSize = new System.Drawing.Size(240, 200);

            trackVolume = new TrackBar();
            trackVolume.Location = new System.Drawing.Point(30, 20);
            trackVolume.Maximum = 100;
            trackVolume.Value = Properties.Settings.Default.Volume;
            trackVolume.Scroll += (s, ev) => MediaPlayerManager.SetVolume(trackVolume.Value);

            btnToggleLoop = new Button();
            btnToggleLoop.Text = Properties.Settings.Default.IsLoop ? "🔁 Lặp: BẬT" : "⏹️ Lặp: TẮT";
            btnToggleLoop.Size = new System.Drawing.Size(150, 30);
            btnToggleLoop.Location = new System.Drawing.Point(30, 70);
            btnToggleLoop.Click += (s, ev) =>
            {
                MediaPlayerManager.ToggleLoop();
                btnToggleLoop.Text = Properties.Settings.Default.IsLoop ? "🔁 Lặp: BẬT" : "⏹️ Lặp: TẮT";
            };

            btnChonNhac = new Button();
            btnChonNhac.Text = "🎵 Chọn nhạc";
            btnChonNhac.Size = new System.Drawing.Size(150, 30);
            btnChonNhac.Location = new System.Drawing.Point(30, 120);
            btnChonNhac.Click += (s, ev) =>
            {
                Form chonNhacForm = new Form();
                chonNhacForm.Text = "Chọn nhạc nền";
                chonNhacForm.Size = new Size(300, 180);
                chonNhacForm.StartPosition = FormStartPosition.CenterParent;
                chonNhacForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                chonNhacForm.MaximizeBox = false;
                chonNhacForm.MinimizeBox = false;

                Label lbl = new Label()
                {
                    Text = "🎵 Chọn nhạc nền:",
                    Location = new Point(20, 20),
                    AutoSize = true
                };

                ComboBox cboNhac = new ComboBox()
                {
                    Location = new Point(20, 50),
                    Size = new Size(240, 25),
                    DropDownStyle = ComboBoxStyle.DropDownList
                };

                string musicFolder = Path.Combine(Application.StartupPath, "Music");

                if (!Directory.Exists(musicFolder))
                {
                    Directory.CreateDirectory(musicFolder);
                }

                string[] files = Directory.GetFiles(musicFolder, "*.mp3");

                foreach (var file in files)
                {
                    cboNhac.Items.Add(Path.GetFileName(file));
                }

                if (cboNhac.Items.Count > 0)
                {
                    cboNhac.SelectedIndex = 0;
                }

                Button btnOK = new Button()
                {
                    Text = "▶️ Phát",
                    Location = new Point(100, 90),
                    DialogResult = DialogResult.OK
                };

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

                    var key = mapChuDe.Keys.FirstOrDefault(k =>
                        string.Equals(k.Trim(), chuDe, StringComparison.OrdinalIgnoreCase));

                    if (key == null) continue;

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
                        ChuDeID = mapChuDe[key]
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

        private void btnChonDoi_Click(object sender, EventArgs e)
        {
            ChonDoiForm form = new ChonDoiForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                doiChoiID = form.DoiChoiID;
                MessageBox.Show("✅ Đã chọn đội chơi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
