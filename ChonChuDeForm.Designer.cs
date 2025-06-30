namespace Đồ_án_1___Nhóm_14
{
    partial class ChonChuDeForm
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
        /// <summary>
        /// Thiết lập giao diện của form
        /// </summary>

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnLichSu;
        private System.Windows.Forms.Button btnKhoaHoc;
        private System.Windows.Forms.Button btnDiaLy;
        private System.Windows.Forms.Button btnTheThao;
        private System.Windows.Forms.Button btnNgheThuat;
        private System.Windows.Forms.Button btnCongNghe;
        private System.Windows.Forms.Button btnVanHoc;
        private System.Windows.Forms.Button btnTheGioi;
        private System.Windows.Forms.Button btnHoaHoc;
        private System.Windows.Forms.Button btnNgauNhien;
        private System.Windows.Forms.Button btnHuy;

        private void InitializeComponent()
        {
            this.btnLichSu = new System.Windows.Forms.Button();
            this.btnKhoaHoc = new System.Windows.Forms.Button();
            this.btnDiaLy = new System.Windows.Forms.Button();
            this.btnTheThao = new System.Windows.Forms.Button();
            this.btnNgheThuat = new System.Windows.Forms.Button();
            this.btnCongNghe = new System.Windows.Forms.Button();
            this.btnVanHoc = new System.Windows.Forms.Button();
            this.btnTheGioi = new System.Windows.Forms.Button();
            this.btnHoaHoc = new System.Windows.Forms.Button();
            this.btnNgauNhien = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnLichSu
            this.btnLichSu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLichSu.Location = new System.Drawing.Point(123, 100);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(200, 50);
            this.btnLichSu.TabIndex = 0;
            this.btnLichSu.Text = "📜 Lịch sử";
            this.btnLichSu.UseVisualStyleBackColor = true;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);

            // btnKhoaHoc
            this.btnKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnKhoaHoc.Location = new System.Drawing.Point(424, 100);
            this.btnKhoaHoc.Name = "btnKhoaHoc";
            this.btnKhoaHoc.Size = new System.Drawing.Size(200, 50);
            this.btnKhoaHoc.TabIndex = 1;
            this.btnKhoaHoc.Text = "🔬 Khoa học";
            this.btnKhoaHoc.UseVisualStyleBackColor = true;
            this.btnKhoaHoc.Click += new System.EventHandler(this.btnKhoaHoc_Click);

            // btnDiaLy
            this.btnDiaLy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDiaLy.Location = new System.Drawing.Point(705, 100);
            this.btnDiaLy.Name = "btnDiaLy";
            this.btnDiaLy.Size = new System.Drawing.Size(200, 50);
            this.btnDiaLy.TabIndex = 2;
            this.btnDiaLy.Text = "🗺️ Địa lý";
            this.btnDiaLy.UseVisualStyleBackColor = true;
            this.btnDiaLy.Click += new System.EventHandler(this.btnDiaLy_Click);

            // btnTheThao
            this.btnTheThao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTheThao.Location = new System.Drawing.Point(123, 170);
            this.btnTheThao.Name = "btnTheThao";
            this.btnTheThao.Size = new System.Drawing.Size(200, 50);
            this.btnTheThao.TabIndex = 3;
            this.btnTheThao.Text = "⚽ Thể thao";
            this.btnTheThao.UseVisualStyleBackColor = true;
            this.btnTheThao.Click += new System.EventHandler(this.btnTheThao_Click);

            // btnNgheThuat
            this.btnNgheThuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNgheThuat.Location = new System.Drawing.Point(424, 170);
            this.btnNgheThuat.Name = "btnNgheThuat";
            this.btnNgheThuat.Size = new System.Drawing.Size(200, 50);
            this.btnNgheThuat.TabIndex = 4;
            this.btnNgheThuat.Text = "🎨 Nghệ thuật";
            this.btnNgheThuat.UseVisualStyleBackColor = true;
            this.btnNgheThuat.Click += new System.EventHandler(this.btnNgheThuat_Click);

            // btnCongNghe
            this.btnCongNghe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCongNghe.Location = new System.Drawing.Point(705, 170);
            this.btnCongNghe.Name = "btnCongNghe";
            this.btnCongNghe.Size = new System.Drawing.Size(200, 50);
            this.btnCongNghe.TabIndex = 5;
            this.btnCongNghe.Text = "🌐 Công nghệ";
            this.btnCongNghe.UseVisualStyleBackColor = true;
            this.btnCongNghe.Click += new System.EventHandler(this.btnCongNghe_Click);

            // btnVanHoc
            this.btnVanHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnVanHoc.Location = new System.Drawing.Point(123, 240);
            this.btnVanHoc.Name = "btnVanHoc";
            this.btnVanHoc.Size = new System.Drawing.Size(200, 50);
            this.btnVanHoc.TabIndex = 6;
            this.btnVanHoc.Text = "📚 Văn học";
            this.btnVanHoc.UseVisualStyleBackColor = true;
            this.btnVanHoc.Click += new System.EventHandler(this.btnVanHoc_Click);

            // btnTheGioi
            this.btnTheGioi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnTheGioi.Location = new System.Drawing.Point(424, 240);
            this.btnTheGioi.Name = "btnTheGioi";
            this.btnTheGioi.Size = new System.Drawing.Size(200, 50);
            this.btnTheGioi.TabIndex = 7;
            this.btnTheGioi.Text = "🌍 Thế giới";
            this.btnTheGioi.UseVisualStyleBackColor = true;
            this.btnTheGioi.Click += new System.EventHandler(this.btnTheGioi_Click);

            // btnHoaHoc
            this.btnHoaHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoaHoc.Location = new System.Drawing.Point(705, 240);
            this.btnHoaHoc.Name = "btnHoaHoc";
            this.btnHoaHoc.Size = new System.Drawing.Size(200, 50);
            this.btnHoaHoc.TabIndex = 8;
            this.btnHoaHoc.Text = "🧪 Hóa học";
            this.btnHoaHoc.UseVisualStyleBackColor = true;
            this.btnHoaHoc.Click += new System.EventHandler(this.btnHoaHoc_Click);

            // btnNgauNhien
            this.btnNgauNhien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNgauNhien.Location = new System.Drawing.Point(261, 330);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(200, 50);
            this.btnNgauNhien.TabIndex = 9;
            this.btnNgauNhien.Text = "🎲 Ngẫu Nhiên";
            this.btnNgauNhien.UseVisualStyleBackColor = true;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);

            // btnHuy
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Location = new System.Drawing.Point(577, 330);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(200, 50);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "🔙 Quay lại";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // lblTieuDe
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.Black;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1024, 50);
            this.lblTieuDe.TabIndex = 99;
            this.lblTieuDe.Text = "🧠 CHỌN CHỦ ĐỀ ĐỐ VUI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ChonChuDeForm
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnLichSu);
            this.Controls.Add(this.btnKhoaHoc);
            this.Controls.Add(this.btnDiaLy);
            this.Controls.Add(this.btnTheThao);
            this.Controls.Add(this.btnNgheThuat);
            this.Controls.Add(this.btnCongNghe);
            this.Controls.Add(this.btnVanHoc);
            this.Controls.Add(this.btnTheGioi);
            this.Controls.Add(this.btnHoaHoc);
            this.Controls.Add(this.btnNgauNhien);
            this.Controls.Add(this.btnHuy);
            this.Name = "ChonChuDeForm";
            this.ResumeLayout(false);
        }
    }
}