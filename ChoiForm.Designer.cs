using System.Windows.Forms;

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

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.Label lblThongTin;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.TableLayoutPanel answerLayout;
        private System.Windows.Forms.Button btnDapAnA;
        private System.Windows.Forms.Button btnDapAnB;
        private System.Windows.Forms.Button btnDapAnC;
        private System.Windows.Forms.Button btnDapAnD;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Button btnLuatChoi;
        private System.Windows.Forms.Timer timer1;

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
            this.btnLuatChoi = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblCauHoi
            this.lblCauHoi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCauHoi.Location = new System.Drawing.Point(50, 80);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(1180, 100);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            this.lblCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnDapAnA
            this.btnDapAnA.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnDapAnA.Location = new System.Drawing.Point(150, 220);
            this.btnDapAnA.Name = "btnDapAnA";
            this.btnDapAnA.Size = new System.Drawing.Size(450, 70);
            this.btnDapAnA.Text = "A. Đáp án A";
            this.btnDapAnA.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnDapAnA.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDapAnA.ForeColor = System.Drawing.Color.White;
            this.btnDapAnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDapAnA.Click += new System.EventHandler(this.btnDapAnA_Click);

            // btnDapAnB
            this.btnDapAnB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnDapAnB.Location = new System.Drawing.Point(680, 220);
            this.btnDapAnB.Name = "btnDapAnB";
            this.btnDapAnB.Size = new System.Drawing.Size(450, 70);
            this.btnDapAnB.Text = "B. Đáp án B";
            this.btnDapAnB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnDapAnB.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDapAnB.ForeColor = System.Drawing.Color.White;
            this.btnDapAnB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDapAnB.Click += new System.EventHandler(this.btnDapAnB_Click);

            // btnDapAnC
            this.btnDapAnC.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.btnDapAnC.Location = new System.Drawing.Point(150, 310);
            this.btnDapAnC.Name = "btnDapAnC";
            this.btnDapAnC.Size = new System.Drawing.Size(450, 70);
            this.btnDapAnC.Text = "C. Đáp án C";
            this.btnDapAnC.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnDapAnC.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDapAnC.ForeColor = System.Drawing.Color.White;
            this.btnDapAnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDapAnC.Click += new System.EventHandler(this.btnDapAnC_Click);

            // btnDapAnD
            this.btnDapAnD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnDapAnD.Location = new System.Drawing.Point(680, 310);
            this.btnDapAnD.Name = "btnDapAnD";
            this.btnDapAnD.Size = new System.Drawing.Size(450, 70);
            this.btnDapAnD.Text = "D. Đáp án D";
            this.btnDapAnD.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnDapAnD.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDapAnD.ForeColor = System.Drawing.Color.White;
            this.btnDapAnD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDapAnD.Click += new System.EventHandler(this.btnDapAnD_Click);

            // lblThoiGian
            this.lblThoiGian.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.lblThoiGian.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblThoiGian.Location = new System.Drawing.Point(1150, 20);
            this.lblThoiGian.Size = new System.Drawing.Size(100, 30);
            this.lblThoiGian.Text = "30s";
            this.lblThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblDiem
            this.lblDiem.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDiem.Location = new System.Drawing.Point(30, 20);
            this.lblDiem.Text = "Chủ đề: ... | Điểm: 0";

            // btnLuatChoi
            this.btnLuatChoi.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnLuatChoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLuatChoi.Location = new System.Drawing.Point(20, 640);
            this.btnLuatChoi.Size = new System.Drawing.Size(50, 50);
            this.btnLuatChoi.Text = "?";
            this.btnLuatChoi.Click += new System.EventHandler(this.btnLuatChoi_Click);

            // timer1
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            // ChoiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.btnDapAnA);
            this.Controls.Add(this.btnDapAnB);
            this.Controls.Add(this.btnDapAnC);
            this.Controls.Add(this.btnDapAnD);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.btnLuatChoi);
            this.Name = "ChoiForm";
            this.Text = "Quiz Game";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}