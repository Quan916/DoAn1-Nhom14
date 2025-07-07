using System.Windows.Forms;

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

        private System.Windows.Forms.Label lblChonDoi;
        private System.Windows.Forms.ComboBox cboDoiCoSan;
        private System.Windows.Forms.Label lblTaoDoi;
        private System.Windows.Forms.TextBox txtTenDoi;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnChoi;
        private System.Windows.Forms.Button btnHuy;

        private void InitializeComponent()
        {
            this.lblChonDoi = new System.Windows.Forms.Label();
            this.cboDoiCoSan = new System.Windows.Forms.ComboBox();
            this.lblTaoDoi = new System.Windows.Forms.Label();
            this.txtTenDoi = new System.Windows.Forms.TextBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnChoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblChonDoi
            this.lblChonDoi.AutoSize = true;
            this.lblChonDoi.Location = new System.Drawing.Point(30, 30);
            this.lblChonDoi.Text = "🔽 Chọn đội chơi có sẵn:";

            // cboDoiCoSan
            this.cboDoiCoSan.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboDoiCoSan.Location = new System.Drawing.Point(30, 60);
            this.cboDoiCoSan.Size = new System.Drawing.Size(300, 25);

            // lblTaoDoi
            this.lblTaoDoi.AutoSize = true;
            this.lblTaoDoi.Location = new System.Drawing.Point(30, 110);
            this.lblTaoDoi.Text = "➕ Tạo đội mới:";

            // txtTenDoi
            this.txtTenDoi.Location = new System.Drawing.Point(30, 140);
            this.txtTenDoi.Size = new System.Drawing.Size(300, 25);

            // btnTaoMoi
            this.btnTaoMoi.Text = "Tạo mới";
            this.btnTaoMoi.Location = new System.Drawing.Point(250, 180);
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);

            // btnChoi
            this.btnChoi.Text = "✅ Chơi";
            this.btnChoi.Location = new System.Drawing.Point(30, 240);
            this.btnChoi.Click += new System.EventHandler(this.btnChoi_Click);

            // btnHuy
            this.btnHuy.Text = "❌ Hủy";
            this.btnHuy.Location = new System.Drawing.Point(150, 240);
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.lblChonDoi);
            this.Controls.Add(this.cboDoiCoSan);
            this.Controls.Add(this.lblTaoDoi);
            this.Controls.Add(this.txtTenDoi);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.btnChoi);
            this.Controls.Add(this.btnHuy);
            this.Text = "🧑‍🤝‍🧑 Chọn hoặc Tạo Đội Chơi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
