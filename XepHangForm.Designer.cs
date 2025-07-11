using System;
using System.Drawing;
using System.Windows.Forms;

namespace Đồ_án_1___Nhóm_14
{
    partial class XepHangForm
    {
        private System.ComponentModel.IContainer components = null;

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
        private TableLayoutPanel buttonLayout;
        private Button btnReset;
        private Button btnDong;
        private TabControl tabControl1;
        private TabPage tabCaNhan;
        private TabPage tabNhom;
        private DataGridView dgvCaNhan;
        private DataGridView dgvNhom;

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCaNhan = new System.Windows.Forms.TabPage();
            this.dgvCaNhan = new System.Windows.Forms.DataGridView();
            this.tabNhom = new System.Windows.Forms.TabPage();
            this.dgvNhom = new System.Windows.Forms.DataGridView();
            this.buttonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.mainLayout.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCaNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaNhan)).BeginInit();
            this.tabNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).BeginInit();
            this.buttonLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTieuDe.Location = new System.Drawing.Point(3, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1018, 150);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "📊 BẢNG XẾP HẠNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.lblTieuDe, 0, 0);
            this.mainLayout.Controls.Add(this.tabControl1, 0, 1);
            this.mainLayout.Controls.Add(this.buttonLayout, 0, 2);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.mainLayout.Size = new System.Drawing.Size(1024, 600);
            this.mainLayout.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCaNhan);
            this.tabControl1.Controls.Add(this.tabNhom);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 153);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 354);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCaNhan
            // 
            this.tabCaNhan.Controls.Add(this.dgvCaNhan);
            this.tabCaNhan.Location = new System.Drawing.Point(4, 25);
            this.tabCaNhan.Name = "tabCaNhan";
            this.tabCaNhan.Size = new System.Drawing.Size(1010, 325);
            this.tabCaNhan.TabIndex = 0;
            this.tabCaNhan.Text = "Cá nhân";
            // 
            // dgvCaNhan
            // 
            this.dgvCaNhan.AllowUserToAddRows = false;
            this.dgvCaNhan.AllowUserToDeleteRows = false;
            this.dgvCaNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCaNhan.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaNhan.ColumnHeadersHeight = 29;
            this.dgvCaNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCaNhan.Location = new System.Drawing.Point(0, 0);
            this.dgvCaNhan.Name = "dgvCaNhan";
            this.dgvCaNhan.ReadOnly = true;
            this.dgvCaNhan.RowHeadersWidth = 51;
            this.dgvCaNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaNhan.Size = new System.Drawing.Size(1010, 325);
            this.dgvCaNhan.TabIndex = 0;
            // 
            // tabNhom
            // 
            this.tabNhom.Controls.Add(this.dgvNhom);
            this.tabNhom.Location = new System.Drawing.Point(4, 25);
            this.tabNhom.Name = "tabNhom";
            this.tabNhom.Size = new System.Drawing.Size(192, 71);
            this.tabNhom.TabIndex = 1;
            this.tabNhom.Text = "Đội nhóm";
            // 
            // dgvNhom
            // 
            this.dgvNhom.AllowUserToAddRows = false;
            this.dgvNhom.AllowUserToDeleteRows = false;
            this.dgvNhom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhom.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhom.ColumnHeadersHeight = 29;
            this.dgvNhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhom.Location = new System.Drawing.Point(0, 0);
            this.dgvNhom.Name = "dgvNhom";
            this.dgvNhom.ReadOnly = true;
            this.dgvNhom.RowHeadersWidth = 51;
            this.dgvNhom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhom.Size = new System.Drawing.Size(192, 71);
            this.dgvNhom.TabIndex = 0;
            // 
            // buttonLayout
            // 
            this.buttonLayout.ColumnCount = 2;
            this.buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonLayout.Controls.Add(this.btnReset, 0, 0);
            this.buttonLayout.Controls.Add(this.btnDong, 1, 0);
            this.buttonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLayout.Location = new System.Drawing.Point(3, 513);
            this.buttonLayout.Name = "buttonLayout";
            this.buttonLayout.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.buttonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonLayout.Size = new System.Drawing.Size(1018, 84);
            this.buttonLayout.TabIndex = 2;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.OrangeRed;
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(33, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(473, 58);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "🔄 Xóa toàn bộ";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.LightGray;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDong.Location = new System.Drawing.Point(512, 13);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(473, 58);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "❌ Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // XepHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.mainLayout);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "XepHangForm";
            this.Text = "📊 Bảng xếp hạng";
            this.mainLayout.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCaNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaNhan)).EndInit();
            this.tabNhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhom)).EndInit();
            this.buttonLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
