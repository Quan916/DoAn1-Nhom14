using AxWMPLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using NAudio.Wave;

namespace Đồ_án_1___Nhóm_14
{
    internal class MediaPlayerManager
    {
        private static WaveOutEvent musicOutput;
        private static AudioFileReader musicReader;
        private static bool isLooping = false;
        private static float currentVolume = 1.0f;

        /// Phát nhạc nền
        public static void ChangeMusic(string filePath)
        {
            StopMusic();

            if (!File.Exists(filePath)) return;

            try
            {
                musicReader = new AudioFileReader(filePath)
                {
                    Volume = currentVolume
                };

                musicOutput = new WaveOutEvent();
                musicOutput.Init(musicReader);
                musicOutput.Play();

                musicOutput.PlaybackStopped += (s, e) =>
                {
                    if (isLooping)
                    {
                        musicReader.Position = 0;
                        musicOutput.Play();
                    }
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi phát nhạc nền: " + ex.Message);
            }
        }

        /// Dừng nhạc nền
        public static void StopMusic()
        {
            if (musicOutput != null)
            {
                musicOutput.Stop();
                musicOutput.Dispose();
                musicOutput = null;
            }

            if (musicReader != null)
            {
                musicReader.Dispose();
                musicReader = null;
            }
        }

        /// Bật hoặc tắt lặp nhạc
        public static void ToggleLoop(bool enable)
        {
            isLooping = enable;
        }

        /// Đặt âm lượng nhạc nền (0–100)
        public static void SetVolume(int volume)
        {
            currentVolume = volume / 100f;

            if (musicReader != null)
                musicReader.Volume = currentVolume;
        }

        /// Phát âm thanh hiệu ứng (đúng/sai)
        public static void PlaySoundEffect(string filePath, int volume = 100)
        {
            if (!File.Exists(filePath)) return;

            try
            {
                var reader = new AudioFileReader(filePath)
                {
                    Volume = volume / 100f
                };

                var output = new WaveOutEvent();
                output.Init(reader);
                output.Play();

                output.PlaybackStopped += (s, e) =>
                {
                    output.Dispose();
                    reader.Dispose();
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi phát hiệu ứng âm thanh: " + ex.Message);
            }
        }

        public static void Init()
        {
            string path = Properties.Settings.Default.MusicPath;
            if (!string.IsNullOrEmpty(path) && File.Exists(path))
            {
                ChangeMusic(path);
                ToggleLoop(Properties.Settings.Default.IsLoop);
                SetVolume(Properties.Settings.Default.Volume);
            }
        }
    }
}