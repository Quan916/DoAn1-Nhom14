using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Đồ_án_1___Nhóm_14
{
    partial class ChonDoiForm
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
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel formLayout;
        private TableLayoutPanel buttonLayout;

        private Label lblChonDoi;
        private ComboBox cboDoiCoSan;
        private Label lblTaoDoi;
        private TextBox txtTenDoi;

        private IconButton btnChoi;
        private IconButton btnHuy;

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblChonDoi = new System.Windows.Forms.Label();
            this.cboDoiCoSan = new System.Windows.Forms.ComboBox();
            this.lblTaoDoi = new System.Windows.Forms.Label();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnChoi = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1280, 252);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🧑‍🤝‍🧑 CHỌN HOẶC TẠO ĐỘI CHƠI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChonDoi
            // 
            this.lblChonDoi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblChonDoi.Location = new System.Drawing.Point(290, 270);
            this.lblChonDoi.Name = "lblChonDoi";
            this.lblChonDoi.Size = new System.Drawing.Size(300, 46);
            this.lblChonDoi.TabIndex = 1;
            this.lblChonDoi.Text = "🔽 Chọn đội chơi có sẵn:";
            this.lblChonDoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDoiCoSan
            // 
            this.cboDoiCoSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiCoSan.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.cboDoiCoSan.Location = new System.Drawing.Point(600, 273);
            this.cboDoiCoSan.Name = "cboDoiCoSan";
            this.cboDoiCoSan.Size = new System.Drawing.Size(400, 43);
            this.cboDoiCoSan.TabIndex = 2;
            // 
            // lblTaoDoi
            // 
            this.lblTaoDoi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTaoDoi.Location = new System.Drawing.Point(290, 360);
            this.lblTaoDoi.Name = "lblTaoDoi";
            this.lblTaoDoi.Size = new System.Drawing.Size(300, 46);
            this.lblTaoDoi.TabIndex = 3;
            this.lblTaoDoi.Text = "➕ Tạo đội mới:";
            this.lblTaoDoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtTenDoi.Location = new System.Drawing.Point(600, 363);
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(400, 41);
            this.txtTenDoi.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnHuy.IconColor = System.Drawing.Color.Black;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.Location = new System.Drawing.Point(440, 520);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(180, 50);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "❌ Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChoi
            // 
            this.btnChoi.BackColor = System.Drawing.Color.LightGreen;
            this.btnChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnChoi.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnChoi.IconColor = System.Drawing.Color.Black;
            this.btnChoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChoi.Location = new System.Drawing.Point(660, 520);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(180, 50);
            this.btnChoi.TabIndex = 6;
            this.btnChoi.Text = "▶️ Bắt đầu chơi";
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // ChonDoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.lblChonDoi);
            this.Controls.Add(this.cboDoiCoSan);
            this.Controls.Add(this.lblTaoDoi);
            this.Controls.Add(this.txtTenDoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "ChonDoiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn hoặc Tạo Đội Chơi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}