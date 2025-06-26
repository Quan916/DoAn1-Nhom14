using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public partial class CaiDatAmThanhForm : Form
    {
        public CaiDatAmThanhForm()
        {
            InitializeComponent();
        }

        private void CaiDatAmThanhForm_Load(object sender, EventArgs e)
        {
            trackVolume.Value = Properties.Settings.Default.Volume;
            btnToggleLoop.Text = Properties.Settings.Default.IsLoop ? "🔁 Lặp: BẬT" : "⏹️ Lặp: TẮT";
        }

        private void btnChonNhac_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "MP3 files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    MediaPlayerManager.ChangeMusic(ofd.FileName);
                }
            }
        }
    }
}
