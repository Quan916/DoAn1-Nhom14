using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

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

        private Label lblTieuDe;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel buttonPanel;

        private IconButton btnLichSu;
        private IconButton btnKhoaHoc;
        private IconButton btnDiaLy;
        private IconButton btnTheThao;
        private IconButton btnNgheThuat;
        private IconButton btnCongNghe;
        private IconButton btnVanHoc;
        private IconButton btnTheGioi;
        private IconButton btnHoaHoc;
        private IconButton btnNgauNhien;
        private IconButton btnQuayLai;

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnLichSu = new FontAwesome.Sharp.IconButton();
            this.btnKhoaHoc = new FontAwesome.Sharp.IconButton();
            this.btnDiaLy = new FontAwesome.Sharp.IconButton();
            this.btnTheThao = new FontAwesome.Sharp.IconButton();
            this.btnNgheThuat = new FontAwesome.Sharp.IconButton();
            this.btnCongNghe = new FontAwesome.Sharp.IconButton();
            this.btnVanHoc = new FontAwesome.Sharp.IconButton();
            this.btnTheGioi = new FontAwesome.Sharp.IconButton();
            this.btnHoaHoc = new FontAwesome.Sharp.IconButton();
            this.btnNgauNhien = new FontAwesome.Sharp.IconButton();
            this.btnQuayLai = new FontAwesome.Sharp.IconButton();
            this.mainLayout.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            
            // lblTieuDe
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(2, 0);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(764, 98);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🧠 CHỌN CHỦ ĐỀ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // mainLayout
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.mainLayout.Controls.Add(this.lblTieuDe, 0, 0);
            this.mainLayout.Controls.Add(this.buttonPanel, 0, 1);
            this.mainLayout.Controls.Add(this.btnQuayLai, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            this.mainLayout.Size = new System.Drawing.Size(768, 520);
            this.mainLayout.TabIndex = 0;
            
            // buttonPanel
            this.buttonPanel.ColumnCount = 3;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.buttonPanel.Controls.Add(this.btnLichSu, 0, 0);
            this.buttonPanel.Controls.Add(this.btnKhoaHoc, 1, 0);
            this.buttonPanel.Controls.Add(this.btnDiaLy, 2, 0);
            this.buttonPanel.Controls.Add(this.btnTheThao, 0, 1);
            this.buttonPanel.Controls.Add(this.btnNgheThuat, 1, 1);
            this.buttonPanel.Controls.Add(this.btnCongNghe, 2, 1);
            this.buttonPanel.Controls.Add(this.btnVanHoc, 0, 2);
            this.buttonPanel.Controls.Add(this.btnTheGioi, 1, 2);
            this.buttonPanel.Controls.Add(this.btnHoaHoc, 2, 2);
            this.buttonPanel.Controls.Add(this.btnNgauNhien, 1, 3);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(2, 100);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.buttonPanel.RowCount = 4;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.buttonPanel.Size = new System.Drawing.Size(764, 353);
            this.buttonPanel.TabIndex = 1;
            
            // btnLichSu
            this.btnLichSu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLichSu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLichSu.FlatAppearance.BorderSize = 0;
            this.btnLichSu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnLichSu.ForeColor = System.Drawing.Color.White;
            this.btnLichSu.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLichSu.IconColor = System.Drawing.Color.White;
            this.btnLichSu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLichSu.IconSize = 40;
            this.btnLichSu.Location = new System.Drawing.Point(17, 18);
            this.btnLichSu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLichSu.Name = "btnLichSu";
            this.btnLichSu.Size = new System.Drawing.Size(240, 76);
            this.btnLichSu.TabIndex = 0;
            this.btnLichSu.Text = "Lịch sử";
            this.btnLichSu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLichSu.UseVisualStyleBackColor = false;
            this.btnLichSu.Click += new System.EventHandler(this.btnLichSu_Click);
            
            // btnKhoaHoc
            this.btnKhoaHoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKhoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKhoaHoc.FlatAppearance.BorderSize = 0;
            this.btnKhoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhoaHoc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnKhoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnKhoaHoc.IconChar = FontAwesome.Sharp.IconChar.Microscope;
            this.btnKhoaHoc.IconColor = System.Drawing.Color.White;
            this.btnKhoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhoaHoc.IconSize = 40;
            this.btnKhoaHoc.Location = new System.Drawing.Point(261, 18);
            this.btnKhoaHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKhoaHoc.Name = "btnKhoaHoc";
            this.btnKhoaHoc.Size = new System.Drawing.Size(240, 76);
            this.btnKhoaHoc.TabIndex = 1;
            this.btnKhoaHoc.Text = "Khoa học";
            this.btnKhoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhoaHoc.UseVisualStyleBackColor = false;
            this.btnKhoaHoc.Click += new System.EventHandler(this.btnKhoaHoc_Click);
            
            // btnDiaLy
            this.btnDiaLy.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDiaLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiaLy.FlatAppearance.BorderSize = 0;
            this.btnDiaLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiaLy.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnDiaLy.ForeColor = System.Drawing.Color.White;
            this.btnDiaLy.IconChar = FontAwesome.Sharp.IconChar.EarthAsia;
            this.btnDiaLy.IconColor = System.Drawing.Color.White;
            this.btnDiaLy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiaLy.IconSize = 40;
            this.btnDiaLy.Location = new System.Drawing.Point(505, 18);
            this.btnDiaLy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDiaLy.Name = "btnDiaLy";
            this.btnDiaLy.Size = new System.Drawing.Size(242, 76);
            this.btnDiaLy.TabIndex = 2;
            this.btnDiaLy.Text = "Địa lý";
            this.btnDiaLy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiaLy.UseVisualStyleBackColor = false;
            this.btnDiaLy.Click += new System.EventHandler(this.btnDiaLy_Click);
            
            // btnTheThao
            this.btnTheThao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTheThao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTheThao.FlatAppearance.BorderSize = 0;
            this.btnTheThao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheThao.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnTheThao.ForeColor = System.Drawing.Color.White;
            this.btnTheThao.IconChar = FontAwesome.Sharp.IconChar.FutbolBall;
            this.btnTheThao.IconColor = System.Drawing.Color.White;
            this.btnTheThao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheThao.IconSize = 40;
            this.btnTheThao.Location = new System.Drawing.Point(17, 98);
            this.btnTheThao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTheThao.Name = "btnTheThao";
            this.btnTheThao.Size = new System.Drawing.Size(240, 76);
            this.btnTheThao.TabIndex = 3;
            this.btnTheThao.Text = "Thể thao";
            this.btnTheThao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheThao.UseVisualStyleBackColor = false;
            this.btnTheThao.Click += new System.EventHandler(this.btnTheThao_Click);
            
            // btnNgheThuat
            this.btnNgheThuat.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnNgheThuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNgheThuat.FlatAppearance.BorderSize = 0;
            this.btnNgheThuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgheThuat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnNgheThuat.ForeColor = System.Drawing.Color.White;
            this.btnNgheThuat.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.btnNgheThuat.IconColor = System.Drawing.Color.White;
            this.btnNgheThuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNgheThuat.IconSize = 40;
            this.btnNgheThuat.Location = new System.Drawing.Point(261, 98);
            this.btnNgheThuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNgheThuat.Name = "btnNgheThuat";
            this.btnNgheThuat.Size = new System.Drawing.Size(240, 76);
            this.btnNgheThuat.TabIndex = 4;
            this.btnNgheThuat.Text = "Nghệ thuật";
            this.btnNgheThuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNgheThuat.UseVisualStyleBackColor = false;
            this.btnNgheThuat.Click += new System.EventHandler(this.btnNgheThuat_Click);
            
            // btnCongNghe
            this.btnCongNghe.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCongNghe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCongNghe.FlatAppearance.BorderSize = 0;
            this.btnCongNghe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCongNghe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnCongNghe.ForeColor = System.Drawing.Color.White;
            this.btnCongNghe.IconChar = FontAwesome.Sharp.IconChar.Microchip;
            this.btnCongNghe.IconColor = System.Drawing.Color.White;
            this.btnCongNghe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCongNghe.IconSize = 40;
            this.btnCongNghe.Location = new System.Drawing.Point(505, 98);
            this.btnCongNghe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCongNghe.Name = "btnCongNghe";
            this.btnCongNghe.Size = new System.Drawing.Size(242, 76);
            this.btnCongNghe.TabIndex = 5;
            this.btnCongNghe.Text = "Công nghệ";
            this.btnCongNghe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCongNghe.UseVisualStyleBackColor = false;
            this.btnCongNghe.Click += new System.EventHandler(this.btnCongNghe_Click);
            
            // btnVanHoc
            this.btnVanHoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVanHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVanHoc.FlatAppearance.BorderSize = 0;
            this.btnVanHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVanHoc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnVanHoc.ForeColor = System.Drawing.Color.White;
            this.btnVanHoc.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnVanHoc.IconColor = System.Drawing.Color.White;
            this.btnVanHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVanHoc.IconSize = 40;
            this.btnVanHoc.Location = new System.Drawing.Point(17, 178);
            this.btnVanHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVanHoc.Name = "btnVanHoc";
            this.btnVanHoc.Size = new System.Drawing.Size(240, 76);
            this.btnVanHoc.TabIndex = 6;
            this.btnVanHoc.Text = "Văn học";
            this.btnVanHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVanHoc.UseVisualStyleBackColor = false;
            this.btnVanHoc.Click += new System.EventHandler(this.btnVanHoc_Click);
            
            // btnTheGioi
            this.btnTheGioi.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTheGioi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTheGioi.FlatAppearance.BorderSize = 0;
            this.btnTheGioi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheGioi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnTheGioi.ForeColor = System.Drawing.Color.White;
            this.btnTheGioi.IconChar = FontAwesome.Sharp.IconChar.Globe;
            this.btnTheGioi.IconColor = System.Drawing.Color.White;
            this.btnTheGioi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheGioi.IconSize = 40;
            this.btnTheGioi.Location = new System.Drawing.Point(261, 178);
            this.btnTheGioi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTheGioi.Name = "btnTheGioi";
            this.btnTheGioi.Size = new System.Drawing.Size(240, 76);
            this.btnTheGioi.TabIndex = 7;
            this.btnTheGioi.Text = "Thế giới";
            this.btnTheGioi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheGioi.UseVisualStyleBackColor = false;
            this.btnTheGioi.Click += new System.EventHandler(this.btnTheGioi_Click);
            
            // btnHoaHoc
            this.btnHoaHoc.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHoaHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHoaHoc.FlatAppearance.BorderSize = 0;
            this.btnHoaHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaHoc.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnHoaHoc.ForeColor = System.Drawing.Color.White;
            this.btnHoaHoc.IconChar = FontAwesome.Sharp.IconChar.Flask;
            this.btnHoaHoc.IconColor = System.Drawing.Color.White;
            this.btnHoaHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHoaHoc.IconSize = 40;
            this.btnHoaHoc.Location = new System.Drawing.Point(505, 178);
            this.btnHoaHoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHoaHoc.Name = "btnHoaHoc";
            this.btnHoaHoc.Size = new System.Drawing.Size(242, 76);
            this.btnHoaHoc.TabIndex = 8;
            this.btnHoaHoc.Text = "Hóa học";
            this.btnHoaHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaHoc.UseVisualStyleBackColor = false;
            this.btnHoaHoc.Click += new System.EventHandler(this.btnHoaHoc_Click);
            // 
            // btnNgauNhien
            // 
            this.btnNgauNhien.BackColor = System.Drawing.Color.DarkOrange;
            this.btnNgauNhien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNgauNhien.FlatAppearance.BorderSize = 0;
            this.btnNgauNhien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgauNhien.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnNgauNhien.ForeColor = System.Drawing.Color.White;
            this.btnNgauNhien.IconChar = FontAwesome.Sharp.IconChar.Dice;
            this.btnNgauNhien.IconColor = System.Drawing.Color.White;
            this.btnNgauNhien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNgauNhien.IconSize = 40;
            this.btnNgauNhien.Location = new System.Drawing.Point(261, 258);
            this.btnNgauNhien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNgauNhien.Name = "btnNgauNhien";
            this.btnNgauNhien.Size = new System.Drawing.Size(240, 77);
            this.btnNgauNhien.TabIndex = 9;
            this.btnNgauNhien.Text = "Ngẫu nhiên";
            this.btnNgauNhien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNgauNhien.UseVisualStyleBackColor = false;
            this.btnNgauNhien.Click += new System.EventHandler(this.btnNgauNhien_Click);
            
            // btnQuayLai
            this.btnQuayLai.BackColor = System.Drawing.Color.LightGray;
            this.btnQuayLai.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuayLai.FlatAppearance.BorderSize = 0;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQuayLai.ForeColor = System.Drawing.Color.Black;
            this.btnQuayLai.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnQuayLai.IconColor = System.Drawing.Color.Black;
            this.btnQuayLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuayLai.IconSize = 30;
            this.btnQuayLai.Location = new System.Drawing.Point(15, 463);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(15, 8, 0, 8);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(151, 49);
            this.btnQuayLai.TabIndex = 10;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);

            // ChonChuDeForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainLayout);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChonChuDeForm";
            this.Text = "Chọn Chủ Đề";
            this.mainLayout.ResumeLayout(false);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void AddHover(IconButton btn, Color originalColor)
        {
            btn.MouseEnter += (s, e) => btn.BackColor = Color.MediumBlue;
            btn.MouseLeave += (s, e) => btn.BackColor = originalColor;
        }
    }
}
