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
        private System.Windows.Forms.Button btnToggleLoop;
        private System.Windows.Forms.Button btnChonNhac;

        private void InitializeComponent()
        {
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btnToggleLoop = new System.Windows.Forms.Button();
            this.btnChonNhac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.SuspendLayout();

            // trackVolume
            this.trackVolume.Location = new System.Drawing.Point(12, 20);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(279, 56);
            this.trackVolume.TabIndex = 0;
            this.trackVolume.TickFrequency = 10;

            // btnToggleLoop
            this.btnToggleLoop.Location = new System.Drawing.Point(62, 99);
            this.btnToggleLoop.Name = "btnToggleLoop";
            this.btnToggleLoop.Size = new System.Drawing.Size(180, 35);
            this.btnToggleLoop.TabIndex = 1;
            this.btnToggleLoop.Text = "🔁 Lặp: BẬT";
            this.btnToggleLoop.UseVisualStyleBackColor = true;

            // btnChonNhac
            this.btnChonNhac.Location = new System.Drawing.Point(62, 158);
            this.btnChonNhac.Name = "btnChonNhac";
            this.btnChonNhac.Size = new System.Drawing.Size(180, 35);
            this.btnChonNhac.TabIndex = 2;
            this.btnChonNhac.Text = "🎵 Chọn nhạc";
            this.btnChonNhac.UseVisualStyleBackColor = true;
            this.btnChonNhac.Click += new System.EventHandler(this.btnChonNhac_Click);

            // CaiDatAmThanhForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 234);
            this.Controls.Add(this.trackVolume);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}