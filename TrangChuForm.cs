using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

                var choiForm = new ChoiForm(danhSachTheoChuDe);
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
            List<CauHoi> danhSach = new List<CauHoi>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                var config = new ExcelDataSetConfiguration
                {
                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration
                    {
                        UseHeaderRow = true
                    }
                };

                var dataSet = reader.AsDataSet(config);
                var table = dataSet.Tables[0];

                foreach (DataRow row in table.Rows)
                {
                    CauHoi ch = new CauHoi
                    {
                        NoiDung = row["NoiDung"].ToString(),
                        DapAnA = row["DapAnA"].ToString(),
                        DapAnB = row["DapAnB"].ToString(),
                        DapAnC = row["DapAnC"].ToString(),
                        DapAnD = row["DapAnD"].ToString(),
                        DapAnDung = row["DapAnDung"].ToString(),
                        GiaiThich = row["GiaiThich"].ToString(),
                        ChuDe = row["ChuDe"].ToString()
                    };

                    danhSach.Add(ch);
                }
            }

            return danhSach;
        }
    }
}
