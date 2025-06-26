namespace Đồ_án_1___Nhóm_14
{
    partial class TrangChuForm
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

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnChonChuDe;
        private System.Windows.Forms.Button btnBangXepHang;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnThoat;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuForm));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnChonChuDe = new System.Windows.Forms.Button();
            this.btnBangXepHang = new System.Windows.Forms.Button();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(140, 100);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(800, 57);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🧠 Trò chơi Đố vui Kiến thức Tổng hợp";
            // 
            // btnChonChuDe
            // 
            this.btnChonChuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonChuDe.Location = new System.Drawing.Point(401, 210);
            this.btnChonChuDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChonChuDe.Name = "btnChonChuDe";
            this.btnChonChuDe.Size = new System.Drawing.Size(249, 40);
            this.btnChonChuDe.TabIndex = 1;
            this.btnChonChuDe.Text = "📚 Chọn Chủ Đề";
            this.btnChonChuDe.UseVisualStyleBackColor = true;
            this.btnChonChuDe.Click += new System.EventHandler(this.btnChonChuDe_Click);
            // 
            // btnBangXepHang
            // 
            this.btnBangXepHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBangXepHang.Location = new System.Drawing.Point(401, 270);
            this.btnBangXepHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBangXepHang.Name = "btnBangXepHang";
            this.btnBangXepHang.Size = new System.Drawing.Size(249, 40);
            this.btnBangXepHang.TabIndex = 2;
            this.btnBangXepHang.Text = "📈 Bảng Xếp Hạng";
            this.btnBangXepHang.UseVisualStyleBackColor = true;
            this.btnBangXepHang.Click += new System.EventHandler(this.btnBangXepHang_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(0, 0);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(0, 0);
            this.axWMP.TabIndex = 4;
            this.axWMP.Visible = false;
            // 
            // btnSetting
            // 
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetting.Location = new System.Drawing.Point(401, 330);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(249, 40);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "⚙️ Cài Đặt";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(401, 390);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(249, 40);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "❌ Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TrangChuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnChonChuDe);
            this.Controls.Add(this.btnBangXepHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.axWMP);
            this.Controls.Add(this.btnSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TrangChuForm";
            this.Text = "Trò chơi Đố vui Kiến thức Tổng hợp";
            this.Load += new System.EventHandler(this.TrangChuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}