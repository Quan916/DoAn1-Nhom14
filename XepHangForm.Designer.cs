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
        private System.Windows.Forms.DataGridView dgvDiemCao;
        private System.Windows.Forms.Button btnDong;

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.dgvDiemCao = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemCao)).BeginInit();
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
            // dgvDiemCao
            // 
            this.dgvDiemCao.AllowUserToAddRows = false;
            this.dgvDiemCao.AllowUserToDeleteRows = false;
            this.dgvDiemCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiemCao.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDiemCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemCao.Location = new System.Drawing.Point(175, 90);
            this.dgvDiemCao.Name = "dgvDiemCao";
            this.dgvDiemCao.ReadOnly = true;
            this.dgvDiemCao.RowHeadersVisible = false;
            this.dgvDiemCao.RowHeadersWidth = 51;
            this.dgvDiemCao.Size = new System.Drawing.Size(682, 281);
            this.dgvDiemCao.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDong.Location = new System.Drawing.Point(461, 392);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 35);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // XepHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.dgvDiemCao);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "XepHangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Xếp Hạng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemCao)).EndInit();
            this.ResumeLayout(false);

        }
    }
}