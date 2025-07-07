using System;
using System.Drawing;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    partial class XepHangForm
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

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCaNhan;
        private System.Windows.Forms.TabPage tabNhom;
        private System.Windows.Forms.DataGridView dgvCaNhan;
        private System.Windows.Forms.DataGridView dgvNhom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDong;

        private void InitializeComponent()
        {
            this.tabControl1 = new TabControl();
            this.tabCaNhan = new TabPage();
            this.tabNhom = new TabPage();
            this.dgvCaNhan = new DataGridView();
            this.dgvNhom = new DataGridView();
            this.btnReset = new Button();
            this.btnDong = new Button();

            // TabControl
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Controls.Add(this.tabNhom);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Size = new System.Drawing.Size(760, 400);
            this.tabControl1.SelectedIndex = 0;

            // Tab Cá nhân
            this.tabCaNhan.Text = "Cá nhân";
            this.tabCaNhan.Controls.Add(this.dgvCaNhan);
            this.dgvCaNhan.Dock = DockStyle.Fill;

            // Tab Nhóm
            this.tabNhom.Text = "Đội nhóm";
            this.tabNhom.Controls.Add(this.dgvNhom);
            this.dgvNhom.Dock = DockStyle.Fill;

            // Button Reset
            this.btnReset.Text = "🔄 Xóa toàn bộ";
            this.btnReset.Location = new Point(12, 420);
            this.btnReset.Size = new Size(120, 30);
            this.btnReset.Click += new EventHandler(this.btnReset_Click);

            // Button Đóng
            this.btnDong.Text = "❌ Đóng";
            this.btnDong.Location = new Point(652, 420);
            this.btnDong.Size = new Size(120, 30);
            this.btnDong.Click += new EventHandler(this.btnDong_Click);

            // Form
            this.ClientSize = new Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDong);
            this.Text = "📊 Bảng xếp hạng";
        }
    }
}