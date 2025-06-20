namespace Đồ_án_1___Nhóm_14
{
    partial class ChoiForm
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

        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Button btnDapAnA;
        private System.Windows.Forms.Button btnDapAnB;
        private System.Windows.Forms.Button btnDapAnC;
        private System.Windows.Forms.Button btnDapAnD;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDiem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.btnDapAnA = new System.Windows.Forms.Button();
            this.btnDapAnB = new System.Windows.Forms.Button();
            this.btnDapAnC = new System.Windows.Forms.Button();
            this.btnDapAnD = new System.Windows.Forms.Button();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCauHoi.Location = new System.Drawing.Point(51, 66);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(924, 100);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            // 
            // btnDapAnA
            // 
            this.btnDapAnA.Location = new System.Drawing.Point(100, 216);
            this.btnDapAnA.Name = "btnDapAnA";
            this.btnDapAnA.Size = new System.Drawing.Size(380, 60);
            this.btnDapAnA.TabIndex = 1;
            this.btnDapAnA.Click += new System.EventHandler(this.btnDapAnA_Click);
            // 
            // btnDapAnB
            // 
            this.btnDapAnB.Location = new System.Drawing.Point(540, 216);
            this.btnDapAnB.Name = "btnDapAnB";
            this.btnDapAnB.Size = new System.Drawing.Size(380, 60);
            this.btnDapAnB.TabIndex = 2;
            this.btnDapAnB.Click += new System.EventHandler(this.btnDapAnB_Click);
            // 
            // btnDapAnC
            // 
            this.btnDapAnC.Location = new System.Drawing.Point(100, 306);
            this.btnDapAnC.Name = "btnDapAnC";
            this.btnDapAnC.Size = new System.Drawing.Size(380, 60);
            this.btnDapAnC.TabIndex = 3;
            this.btnDapAnC.Click += new System.EventHandler(this.btnDapAnC_Click);
            // 
            // btnDapAnD
            // 
            this.btnDapAnD.Location = new System.Drawing.Point(540, 306);
            this.btnDapAnD.Name = "btnDapAnD";
            this.btnDapAnD.Size = new System.Drawing.Size(380, 60);
            this.btnDapAnD.TabIndex = 4;
            this.btnDapAnD.Click += new System.EventHandler(this.btnDapAnD_Click);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblThoiGian.Location = new System.Drawing.Point(900, 10);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(100, 30);
            this.lblThoiGian.TabIndex = 5;
            this.lblThoiGian.Text = "30s";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDiem.Location = new System.Drawing.Point(30, 20); // vị trí có thể thay đổi tùy bố cục bạn
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(70, 21);
            this.lblDiem.Text = "Điểm: 0";
            this.Controls.Add(this.lblDiem);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChoiForm
            // 
            this.ClientSize = new System.Drawing.Size(1024, 480);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.btnDapAnA);
            this.Controls.Add(this.btnDapAnB);
            this.Controls.Add(this.btnDapAnC);
            this.Controls.Add(this.btnDapAnD);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblDiem);
            this.Name = "ChoiForm";
            this.Text = "Quiz Game";
            this.ResumeLayout(false);

        }
    }
}