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

        private System.Windows.Forms.Label lblTieuDe;
        private FontAwesome.Sharp.IconButton btnChonChuDe;
        private FontAwesome.Sharp.IconButton btnBangXepHang;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnThoat;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private TableLayoutPanel buttonGrid;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChuForm));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnChonChuDe = new FontAwesome.Sharp.IconButton();
            this.btnBangXepHang = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnThoat = new FontAwesome.Sharp.IconButton();
            this.buttonGrid = new System.Windows.Forms.TableLayoutPanel();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();

            this.buttonGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();

            // lblTieuDe
            this.lblTieuDe.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblTieuDe.ForeColor = Color.DarkSlateGray;
            this.lblTieuDe.Location = new Point(0, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new Size(800, 60);
            this.lblTieuDe.Text = "🧠 Đố Vui Kiến Thức Tổng Hợp";
            this.lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;

            // btnChonChuDe
            this.btnChonChuDe.BackColor = Color.RoyalBlue;
            this.btnChonChuDe.Dock = DockStyle.Fill;
            this.btnChonChuDe.FlatStyle = FlatStyle.Flat;
            this.btnChonChuDe.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnChonChuDe.ForeColor = Color.White;
            this.btnChonChuDe.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnChonChuDe.IconColor = Color.White;
            this.btnChonChuDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonChuDe.IconSize = 32;
            this.btnChonChuDe.Text = "Chọn Chủ Đề";
            this.btnChonChuDe.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.btnChonChuDe.Click += new EventHandler(this.btnChonChuDe_Click);

            // btnBangXepHang
            this.btnBangXepHang.BackColor = Color.MediumSeaGreen;
            this.btnBangXepHang.Dock = DockStyle.Fill;
            this.btnBangXepHang.FlatStyle = FlatStyle.Flat;
            this.btnBangXepHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnBangXepHang.ForeColor = Color.White;
            this.btnBangXepHang.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnBangXepHang.IconColor = Color.White;
            this.btnBangXepHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBangXepHang.IconSize = 32;
            this.btnBangXepHang.Text = "Bảng Xếp Hạng";
            this.btnBangXepHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.btnBangXepHang.Click += new EventHandler(this.btnBangXepHang_Click);

            // btnSetting
            this.btnSetting.BackColor = Color.SlateGray;
            this.btnSetting.Dock = DockStyle.Fill;
            this.btnSetting.FlatStyle = FlatStyle.Flat;
            this.btnSetting.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnSetting.ForeColor = Color.White;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSetting.IconColor = Color.White;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.Text = "Cài Đặt";
            this.btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.btnSetting.Click += new EventHandler(this.btnSetting_Click);

            // btnThoat
            this.btnThoat.BackColor = Color.IndianRed;
            this.btnThoat.Dock = DockStyle.Fill;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            this.btnThoat.ForeColor = Color.White;
            this.btnThoat.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnThoat.IconColor = Color.White;
            this.btnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThoat.IconSize = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.btnThoat.Click += new EventHandler(this.btnThoat_Click);

            // buttonGrid
            this.buttonGrid.ColumnCount = 2;
            this.buttonGrid.RowCount = 2;
            this.buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.buttonGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.buttonGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            this.buttonGrid.Controls.Add(this.btnChonChuDe, 0, 0);
            this.buttonGrid.Controls.Add(this.btnBangXepHang, 1, 0);
            this.buttonGrid.Controls.Add(this.btnSetting, 0, 1);
            this.buttonGrid.Controls.Add(this.btnThoat, 1, 1);
            this.buttonGrid.Location = new Point(150, 100);
            this.buttonGrid.Size = new Size(500, 300);

            // axWMP
            this.axWMP.Enabled = true;
            this.axWMP.Location = new Point(-500, -500);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new Size(75, 23);

            // TrangChuForm
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.axWMP);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Trò chơi Đố Vui Kiến Thức Tổng Hợp";
            this.Load += new EventHandler(this.TrangChuForm_Load);

            this.buttonGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
