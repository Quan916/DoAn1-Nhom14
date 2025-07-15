using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;

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
            // Nhạc nền
            trackVolume.Value = Properties.Settings.Default.Volume;
            trackVolume_ValueChanged(trackVolume, EventArgs.Empty);

            // Âm thanh hiệu ứng
            trackEffectVolume.Value = Properties.Settings.Default.EffectVolume;
            lblEffectVolume.Text = $"Âm lượng hiệu ứng: {trackEffectVolume.Value}%";

            // Lặp nhạc
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
                    Properties.Settings.Default.MusicPath = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void trackVolume_ValueChanged(object sender, EventArgs e)
        {
            int volume = trackVolume.Value;
            Properties.Settings.Default.Volume = volume;
            MediaPlayerManager.SetVolume(volume);

            Properties.Settings.Default.Save();
        }

        private void trackEffectVolume_ValueChanged(object sender, EventArgs e)
        {
            int effectVolume = trackEffectVolume.Value;
            Properties.Settings.Default.EffectVolume = effectVolume;
            lblEffectVolume.Text = $"Âm lượng hiệu ứng: {effectVolume}%";
            Properties.Settings.Default.Save();

            try
            {
                MediaPlayerManager.PlaySoundEffect("correct.mp3", effectVolume);
            }
            catch { }
        }

        private void btnToggleLoop_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsLoop = !Properties.Settings.Default.IsLoop;
            btnToggleLoop.Text = Properties.Settings.Default.IsLoop ? "🔁 Lặp: BẬT" : "⏹️ Lặp: TẮT";
            Properties.Settings.Default.Save();

            MediaPlayerManager.ToggleLoop(Properties.Settings.Default.IsLoop);
        }
    }
}