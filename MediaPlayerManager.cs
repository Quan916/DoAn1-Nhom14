using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxWMPLib;
using System.IO;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    public static class MediaPlayerManager
    {
        public static AxWindowsMediaPlayer Player { get; private set; }

        public static bool IsPlaying => Player != null && Player.playState == WMPLib.WMPPlayState.wmppsPlaying;

        public static void Init(AxWindowsMediaPlayer playerControl)
        {
            Player = playerControl;

            string musicSettingPath = Properties.Settings.Default.MusicPath;

            if (string.IsNullOrWhiteSpace(musicSettingPath))
                return; // Không có file nhạc => không phát

            string fullPath = Path.IsPathRooted(musicSettingPath)
                ? musicSettingPath
                : Path.Combine(Application.StartupPath, musicSettingPath);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show($"Không tìm thấy file nhạc: {fullPath}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Player.URL = fullPath;
            Player.settings.setMode("loop", Properties.Settings.Default.IsLoop);
            Player.settings.volume = Properties.Settings.Default.Volume;
            Player.Ctlcontrols.play();
        }

        public static void Toggle()
        {
            if (IsPlaying) Player.Ctlcontrols.pause();
            else Player.Ctlcontrols.play();
        }

        public static void SetVolume(int volume)
        {
            Player.settings.volume = volume;
            Properties.Settings.Default.Volume = volume;
            Properties.Settings.Default.Save();
        }

        public static void ToggleLoop()
        {
            bool newLoop = !Player.settings.getMode("loop");
            Player.settings.setMode("loop", newLoop);
            Properties.Settings.Default.IsLoop = newLoop;
            Properties.Settings.Default.Save();
        }

        public static void ChangeMusic(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Không tìm thấy file nhạc vừa chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Player.URL = path;
            Player.Ctlcontrols.play();

            // Lưu đường dẫn tương đối
            string relativePath = path.StartsWith(Application.StartupPath)
                ? path.Substring(Application.StartupPath.Length).TrimStart('\\')
                : path;

            Properties.Settings.Default.MusicPath = relativePath;
            Properties.Settings.Default.Save();
        }
    }
}