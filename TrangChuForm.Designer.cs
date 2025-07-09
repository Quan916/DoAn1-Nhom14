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
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private Label lblTieuDe;
        private IconButton btnChonChuDe;
        private IconButton btnChonDoi;
        private IconButton btnBangXepHang;
        private IconButton btnSetting;
        private IconButton btnThoat;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private TableLayoutPanel buttonPanel;
        private TableLayoutPanel mainLayout;

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
            this.buttonPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1274, 266);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🧠 Đố Vui Kiến Thức Tổng Hợp";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnChonChuDe
            // 
            this.btnChonChuDe.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonChuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChonChuDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonChuDe.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnChonChuDe.ForeColor = System.Drawing.Color.White;
            this.btnChonChuDe.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnChonChuDe.IconColor = System.Drawing.Color.White;
            this.btnChonChuDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonChuDe.IconSize = 40;
            this.btnChonChuDe.Location = new System.Drawing.Point(23, 23);
            this.btnChonChuDe.Name = "btnChonChuDe";
            this.btnChonChuDe.Size = new System.Drawing.Size(611, 157);
            this.btnChonChuDe.TabIndex = 0;
            this.btnChonChuDe.Text = "Chọn Chủ Đề";
            this.btnChonChuDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonChuDe.UseVisualStyleBackColor = false;
            this.btnChonChuDe.Click += new System.EventHandler(this.btnChonChuDe_Click);
            // 
            // btnChonDoi
            // 
            this.btnChonDoi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnChonDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChonDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonDoi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnChonDoi.ForeColor = System.Drawing.Color.White;
            this.btnChonDoi.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnChonDoi.IconColor = System.Drawing.Color.White;
            this.btnChonDoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonDoi.IconSize = 40;
            this.btnChonDoi.Location = new System.Drawing.Point(640, 23);
            this.btnChonDoi.Name = "btnChonDoi";
            this.btnChonDoi.Size = new System.Drawing.Size(611, 157);
            this.btnChonDoi.TabIndex = 1;
            this.btnChonDoi.Text = "Chọn Đội";
            this.btnChonDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonDoi.UseVisualStyleBackColor = false;
            this.btnChonDoi.Click += new System.EventHandler(this.btnChonDoi_Click);
            // 
            // btnBangXepHang
            // 
            this.btnBangXepHang.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBangXepHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBangXepHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangXepHang.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnBangXepHang.ForeColor = System.Drawing.Color.White;
            this.btnBangXepHang.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnBangXepHang.IconColor = System.Drawing.Color.White;
            this.btnBangXepHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBangXepHang.IconSize = 40;
            this.btnBangXepHang.Location = new System.Drawing.Point(23, 186);
            this.btnBangXepHang.Name = "btnBangXepHang";
            this.btnBangXepHang.Size = new System.Drawing.Size(611, 158);
            this.btnBangXepHang.TabIndex = 2;
            this.btnBangXepHang.Text = "Bảng Xếp Hạng";
            this.btnBangXepHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBangXepHang.UseVisualStyleBackColor = false;
            this.btnBangXepHang.Click += new System.EventHandler(this.btnBangXepHang_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.SlateGray;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSetting.IconColor = System.Drawing.Color.White;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 40;
            this.btnSetting.Location = new System.Drawing.Point(640, 186);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(611, 158);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThoat.BackColor = System.Drawing.Color.IndianRed;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnThoat.IconColor = System.Drawing.Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 40;
            this.btnThoat.Location = new System.Drawing.Point(440, 644);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(400, 70);
            this.btnThoat.TabIndex = 2;
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
            this.axWMP.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.buttonPanel.ColumnCount = 2;
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Controls.Add(this.btnChonChuDe, 0, 0);
            this.buttonPanel.Controls.Add(this.btnChonDoi, 1, 0);
            this.buttonPanel.Controls.Add(this.btnBangXepHang, 0, 1);
            this.buttonPanel.Controls.Add(this.btnSetting, 1, 1);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(3, 269);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Padding = new System.Windows.Forms.Padding(20);
            this.buttonPanel.RowCount = 2;
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonPanel.Size = new System.Drawing.Size(1274, 367);
            this.buttonPanel.TabIndex = 1;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.lblTieuDe, 0, 0);
            this.mainLayout.Controls.Add(this.buttonPanel, 0, 1);
            this.mainLayout.Controls.Add(this.btnThoat, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.6F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.4F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayout.Size = new System.Drawing.Size(1280, 720);
            this.mainLayout.TabIndex = 0;
            // 
            // TrangChuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.axWMP);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "TrangChuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trò chơi Đố Vui Kiến Thức Tổng Hợp";
            this.Load += new System.EventHandler(this.TrangChuForm_Load);
            this.Resize += new System.EventHandler(this.TrangChuForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.mainLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
