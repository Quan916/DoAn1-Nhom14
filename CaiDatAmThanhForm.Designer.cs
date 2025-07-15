using System;
using System.Drawing;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    partial class CaiDatAmThanhForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.TrackBar trackEffectVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblEffectVolume;
        private System.Windows.Forms.Button btnToggleLoop;
        private System.Windows.Forms.Button btnChonNhac;

        private void InitializeComponent()
        {
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.trackEffectVolume = new System.Windows.Forms.TrackBar();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblEffectVolume = new System.Windows.Forms.Label();
            this.btnToggleLoop = new System.Windows.Forms.Button();
            this.btnChonNhac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEffectVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(20, 40);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(260, 56);
            this.trackVolume.TabIndex = 1;
            this.trackVolume.TickFrequency = 10;
            this.trackVolume.ValueChanged += new System.EventHandler(this.trackVolume_ValueChanged);
            // 
            // trackEffectVolume
            // 
            this.trackEffectVolume.Location = new System.Drawing.Point(20, 127);
            this.trackEffectVolume.Maximum = 100;
            this.trackEffectVolume.Name = "trackEffectVolume";
            this.trackEffectVolume.Size = new System.Drawing.Size(260, 56);
            this.trackEffectVolume.TabIndex = 3;
            this.trackEffectVolume.TickFrequency = 10;
            this.trackEffectVolume.ValueChanged += new System.EventHandler(this.trackEffectVolume_ValueChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVolume.Location = new System.Drawing.Point(20, 15);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(165, 23);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Âm lượng nhạc nền:";
            // 
            // lblEffectVolume
            // 
            this.lblEffectVolume.AutoSize = true;
            this.lblEffectVolume.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEffectVolume.Location = new System.Drawing.Point(20, 99);
            this.lblEffectVolume.Name = "lblEffectVolume";
            this.lblEffectVolume.Size = new System.Drawing.Size(162, 23);
            this.lblEffectVolume.TabIndex = 2;
            this.lblEffectVolume.Text = "Âm lượng hiệu ứng:";
            // 
            // btnToggleLoop
            // 
            this.btnToggleLoop.Location = new System.Drawing.Point(71, 189);
            this.btnToggleLoop.Name = "btnToggleLoop";
            this.btnToggleLoop.Size = new System.Drawing.Size(160, 35);
            this.btnToggleLoop.TabIndex = 4;
            this.btnToggleLoop.Text = "🔁 Lặp: BẬT";
            this.btnToggleLoop.Click += new System.EventHandler(this.btnToggleLoop_Click);
            // 
            // btnChonNhac
            // 
            this.btnChonNhac.Location = new System.Drawing.Point(71, 230);
            this.btnChonNhac.Name = "btnChonNhac";
            this.btnChonNhac.Size = new System.Drawing.Size(160, 35);
            this.btnChonNhac.TabIndex = 5;
            this.btnChonNhac.Text = "🎵 Chọn nhạc nền";
            this.btnChonNhac.Click += new System.EventHandler(this.btnChonNhac_Click);
            // 
            // CaiDatAmThanhForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 291);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.lblEffectVolume);
            this.Controls.Add(this.trackEffectVolume);
            this.Controls.Add(this.btnToggleLoop);
            this.Controls.Add(this.btnChonNhac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CaiDatAmThanhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cài đặt âm thanh";
            this.Load += new System.EventHandler(this.CaiDatAmThanhForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackEffectVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}