using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        private Label lblTieuDe;
        private TableLayoutPanel buttonGrid;
        private FontAwesome.Sharp.IconButton btnChonChuDe;
        private FontAwesome.Sharp.IconButton btnChonDoi;
        private FontAwesome.Sharp.IconButton btnBangXepHang;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnThoat;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuForm));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnChonChuDe = new FontAwesome.Sharp.IconButton();
            this.btnChonDoi = new FontAwesome.Sharp.IconButton();
            this.btnBangXepHang = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 86);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(800, 70);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🧠 Đố Vui Kiến Thức Tổng Hợp";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChonChuDe
            // 
            this.btnChonChuDe.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonChuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonChuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonChuDe.ForeColor = System.Drawing.Color.White;
            this.btnChonChuDe.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnChonChuDe.IconColor = System.Drawing.Color.White;
            this.btnChonChuDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonChuDe.IconSize = 32;
            this.btnChonChuDe.Location = new System.Drawing.Point(214, 195);
            this.btnChonChuDe.Name = "btnChonChuDe";
            this.btnChonChuDe.Size = new System.Drawing.Size(200, 50);
            this.btnChonChuDe.TabIndex = 1;
            this.btnChonChuDe.Text = "Chọn Chủ Đề";
            this.btnChonChuDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonChuDe.UseVisualStyleBackColor = false;
            this.btnChonChuDe.Click += new System.EventHandler(this.btnChonChuDe_Click);
            // 
            // btnChonDoi
            // 
            this.btnChonDoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChonDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnChonDoi.ForeColor = System.Drawing.Color.White;
            this.btnChonDoi.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnChonDoi.IconColor = System.Drawing.Color.White;
            this.btnChonDoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonDoi.IconSize = 32;
            this.btnChonDoi.Location = new System.Drawing.Point(420, 195);
            this.btnChonDoi.Name = "btnChonDoi";
            this.btnChonDoi.Size = new System.Drawing.Size(200, 50);
            this.btnChonDoi.TabIndex = 2;
            this.btnChonDoi.Text = "Chọn Đội";
            this.btnChonDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonDoi.UseVisualStyleBackColor = false;
            this.btnChonDoi.Click += new System.EventHandler(this.btnChonDoi_Click);
            // 
            // btnBangXepHang
            // 
            this.btnBangXepHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBangXepHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangXepHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBangXepHang.ForeColor = System.Drawing.Color.White;
            this.btnBangXepHang.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnBangXepHang.IconColor = System.Drawing.Color.White;
            this.btnBangXepHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBangXepHang.IconSize = 32;
            this.btnBangXepHang.Location = new System.Drawing.Point(214, 251);
            this.btnBangXepHang.Name = "btnBangXepHang";
            this.btnBangXepHang.Size = new System.Drawing.Size(200, 50);
            this.btnBangXepHang.TabIndex = 3;
            this.btnBangXepHang.Text = "Bảng Xếp Hạng";
            this.btnBangXepHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBangXepHang.UseVisualStyleBackColor = false;
            this.btnBangXepHang.Click += new System.EventHandler(this.btnBangXepHang_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.SlateGray;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSetting.IconColor = System.Drawing.Color.White;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.Location = new System.Drawing.Point(420, 251);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(200, 50);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 32;
            this.btnThoat.Location = new System.Drawing.Point(312, 307);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(208, 50);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(-500, -500);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(75, 23);
            this.axWMP.TabIndex = 6;
            // 
            // TrangChuForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.btnChonChuDe);
            this.Controls.Add(this.btnChonDoi);
            this.Controls.Add(this.btnBangXepHang);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.axWMP);
            this.Name = "TrangChuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò chơi Đố Vui Kiến Thức Tổng Hợp";
            this.Load += new System.EventHandler(this.TrangChuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);

        }
    }
}