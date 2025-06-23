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

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.DataGridView dgvXepHang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnReset;

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dgvXepHang = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.Location = new System.Drawing.Point(0, 20);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(1029, 50);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "🎖️ BẢNG XẾP HẠNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvXepHang
            // 
            this.dgvXepHang.AllowUserToAddRows = false;
            this.dgvXepHang.AllowUserToDeleteRows = false;
            this.dgvXepHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXepHang.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvXepHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXepHang.Location = new System.Drawing.Point(175, 90);
            this.dgvXepHang.Name = "dgvXepHang";
            this.dgvXepHang.ReadOnly = true;
            this.dgvXepHang.RowHeadersVisible = false;
            this.dgvXepHang.RowHeadersWidth = 51;
            this.dgvXepHang.Size = new System.Drawing.Size(682, 281);
            this.dgvXepHang.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDong.Location = new System.Drawing.Point(548, 394);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(130, 35);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnReset.Location = new System.Drawing.Point(370, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 35);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // XepHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvXepHang);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnReset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XepHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Xếp Hạng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepHang)).EndInit();
            this.ResumeLayout(false);

        }
    }
}