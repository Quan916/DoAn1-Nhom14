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

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel contentLayout;
        private System.Windows.Forms.Label lblChonDoi;
        private System.Windows.Forms.ComboBox cboDoiCoSan;
        private System.Windows.Forms.Label lblTaoDoi;
        private System.Windows.Forms.TextBox txtTenDoi;
        private System.Windows.Forms.FlowLayoutPanel buttonLayout;
        private FontAwesome.Sharp.IconButton btnChoi;
        private FontAwesome.Sharp.IconButton btnHuy;

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.contentLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblChonDoi = new System.Windows.Forms.Label();
            this.cboDoiCoSan = new System.Windows.Forms.ComboBox();
            this.lblTaoDoi = new System.Windows.Forms.Label();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.buttonLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHuy = new FontAwesome.Sharp.IconButton();
            this.btnChoi = new FontAwesome.Sharp.IconButton();
            this.mainLayout.SuspendLayout();
            this.contentLayout.SuspendLayout();
            this.buttonLayout.SuspendLayout();
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
            this.lblTieuDe.Text = "🧑‍🤝‍🧑 CHỌN HOẶC TẠO ĐỘI CHƠI";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1280F));
            this.mainLayout.Controls.Add(this.lblTieuDe, 0, 0);
            this.mainLayout.Controls.Add(this.contentLayout, 0, 1);
            this.mainLayout.Controls.Add(this.buttonLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.Size = new System.Drawing.Size(1280, 720);
            this.mainLayout.TabIndex = 0;
            // 
            // contentLayout
            // 
            this.contentLayout.ColumnCount = 2;
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.93296F));
            this.contentLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.06704F));
            this.contentLayout.Controls.Add(this.lblChonDoi, 0, 0);
            this.contentLayout.Controls.Add(this.cboDoiCoSan, 1, 0);
            this.contentLayout.Controls.Add(this.lblTaoDoi, 0, 1);
            this.contentLayout.Controls.Add(this.txtTenDoi, 1, 1);
            this.contentLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentLayout.Location = new System.Drawing.Point(3, 219);
            this.contentLayout.Name = "contentLayout";
            this.contentLayout.Padding = new System.Windows.Forms.Padding(80);
            this.contentLayout.RowCount = 2;
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentLayout.Size = new System.Drawing.Size(1274, 318);
            this.contentLayout.TabIndex = 1;
            // 
            // lblChonDoi
            // 
            this.lblChonDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChonDoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblChonDoi.Location = new System.Drawing.Point(80, 84);
            this.lblChonDoi.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblChonDoi.Name = "lblChonDoi";
            this.lblChonDoi.Size = new System.Drawing.Size(311, 71);
            this.lblChonDoi.TabIndex = 0;
            this.lblChonDoi.Text = "🔽 Chọn đội chơi:";
            this.lblChonDoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboDoiCoSan
            // 
            this.cboDoiCoSan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboDoiCoSan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiCoSan.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.cboDoiCoSan.Location = new System.Drawing.Point(391, 84);
            this.cboDoiCoSan.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.cboDoiCoSan.Name = "cboDoiCoSan";
            this.cboDoiCoSan.Size = new System.Drawing.Size(803, 45);
            this.cboDoiCoSan.TabIndex = 1;
            // 
            // lblTaoDoi
            // 
            this.lblTaoDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaoDoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTaoDoi.Location = new System.Drawing.Point(80, 163);
            this.lblTaoDoi.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.lblTaoDoi.Name = "lblTaoDoi";
            this.lblTaoDoi.Size = new System.Drawing.Size(311, 71);
            this.lblTaoDoi.TabIndex = 2;
            this.lblTaoDoi.Text = "➕ Tạo đội mới:";
            this.lblTaoDoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTenDoi
            // 
            this.txtTenDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenDoi.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtTenDoi.Location = new System.Drawing.Point(391, 163);
            this.txtTenDoi.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.txtTenDoi.Name = "txtTenDoi";
            this.txtTenDoi.Size = new System.Drawing.Size(803, 43);
            this.txtTenDoi.TabIndex = 3;
            // 
            // buttonLayout
            // 
            this.buttonLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLayout.AutoSize = true;
            this.buttonLayout.Controls.Add(this.btnHuy);
            this.buttonLayout.Controls.Add(this.btnChoi);
            this.buttonLayout.Location = new System.Drawing.Point(274, 577);
            this.buttonLayout.Name = "buttonLayout";
            this.buttonLayout.Padding = new System.Windows.Forms.Padding(10);
            this.buttonLayout.Size = new System.Drawing.Size(732, 106);
            this.buttonLayout.TabIndex = 2;
            this.buttonLayout.WrapContents = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.LightGray;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.Black;
            this.btnHuy.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btnHuy.IconColor = System.Drawing.Color.Black;
            this.btnHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHuy.IconSize = 40;
            this.btnHuy.Location = new System.Drawing.Point(13, 13);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(350, 80);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChoi
            // 
            this.btnChoi.BackColor = System.Drawing.Color.Orange;
            this.btnChoi.FlatAppearance.BorderSize = 0;
            this.btnChoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnChoi.ForeColor = System.Drawing.Color.White;
            this.btnChoi.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnChoi.IconColor = System.Drawing.Color.White;
            this.btnChoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChoi.IconSize = 40;
            this.btnChoi.Location = new System.Drawing.Point(369, 13);
            this.btnChoi.Name = "btnChoi";
            this.btnChoi.Size = new System.Drawing.Size(350, 80);
            this.btnChoi.TabIndex = 1;
            this.btnChoi.Text = "Bắt đầu";
            this.btnChoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChoi.UseVisualStyleBackColor = false;
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);
            // 
            // ChonDoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainLayout);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ChonDoiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn hoặc Tạo Đội Chơi";
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.contentLayout.ResumeLayout(false);
            this.contentLayout.PerformLayout();
            this.buttonLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
