using System;
using System.Drawing;
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

        private TableLayoutPanel mainLayout;
        private TableLayoutPanel headerPanel;
        private FlowLayoutPanel leftInfoPanel;
        private Label lblChuDe;
        private Label lblDiemCao;
        private Label lblDiem;
        private Button btnSetting;
        private Button btnLuatChoi;
        private Label lblCauHoi;
        private TableLayoutPanel answerLayout;
        private Button btnDapAnA;
        private Button btnDapAnB;
        private Button btnDapAnC;
        private Button btnDapAnD;
        private ProgressBar progressThoiGian;
        private Timer timer1;
        private Label lblThoiGian;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.leftInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblChuDe = new System.Windows.Forms.Label();
            this.lblDiemCao = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnLuatChoi = new System.Windows.Forms.Button();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.answerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.btnDapAnA = new System.Windows.Forms.Button();
            this.btnDapAnB = new System.Windows.Forms.Button();
            this.btnDapAnC = new System.Windows.Forms.Button();
            this.btnDapAnD = new System.Windows.Forms.Button();
            this.progressThoiGian = new System.Windows.Forms.ProgressBar();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mainLayout.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.leftInfoPanel.SuspendLayout();
            this.answerLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.headerPanel, 0, 0);
            this.mainLayout.Controls.Add(this.lblCauHoi, 0, 1);
            this.mainLayout.Controls.Add(this.answerLayout, 0, 2);
            this.mainLayout.Controls.Add(this.progressThoiGian, 0, 3);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 5;
            this.mainLayout.RowStyles.Clear();
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));  // header
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));  // câu hỏi
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));  // đáp án
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));  // progress bar
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));   // dòng trống (hoặc có thể bỏ)

            this.mainLayout.Size = new System.Drawing.Size(1280, 720);
            this.mainLayout.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.ColumnCount = 5;
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.headerPanel.Controls.Add(this.leftInfoPanel, 0, 0);
            this.headerPanel.Controls.Add(this.btnSetting, 3, 0);
            this.headerPanel.Controls.Add(this.btnLuatChoi, 4, 0);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(3, 3);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.headerPanel.Size = new System.Drawing.Size(1274, 54);
            this.headerPanel.TabIndex = 0;
            // 
            // leftInfoPanel
            // 
            this.leftInfoPanel.AutoSize = true;
            this.leftInfoPanel.Controls.Add(this.lblChuDe);
            this.leftInfoPanel.Controls.Add(this.lblDiemCao);
            this.leftInfoPanel.Controls.Add(this.lblDiem);
            this.leftInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.leftInfoPanel.Name = "leftInfoPanel";
            this.leftInfoPanel.Size = new System.Drawing.Size(874, 48);
            this.leftInfoPanel.TabIndex = 0;
            this.leftInfoPanel.WrapContents = false;
            // 
            // lblChuDe
            // 
            this.lblChuDe.AutoSize = true;
            this.lblChuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblChuDe.Location = new System.Drawing.Point(3, 0);
            this.lblChuDe.Name = "lblChuDe";
            this.lblChuDe.Size = new System.Drawing.Size(113, 28);
            this.lblChuDe.TabIndex = 0;
            this.lblChuDe.Text = "Chủ đề: ___";
            this.lblChuDe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiemCao
            // 
            this.lblDiemCao.AutoSize = true;
            this.lblDiemCao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiemCao.Location = new System.Drawing.Point(122, 0);
            this.lblDiemCao.Name = "lblDiemCao";
            this.lblDiemCao.Size = new System.Drawing.Size(196, 28);
            this.lblDiemCao.TabIndex = 1;
            this.lblDiemCao.Text = "  |  Điểm cao nhất: ___";
            this.lblDiemCao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDiem.Location = new System.Drawing.Point(324, 0);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(116, 28);
            this.lblDiem.TabIndex = 2;
            this.lblDiem.Text = "  |  Điểm: ___";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSetting.Location = new System.Drawing.Point(1175, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(44, 48);
            this.btnSetting.TabIndex = 1;
            this.btnSetting.Text = "⚙";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnLuatChoi
            // 
            this.btnLuatChoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuatChoi.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLuatChoi.Location = new System.Drawing.Point(1225, 3);
            this.btnLuatChoi.Name = "btnLuatChoi";
            this.btnLuatChoi.Size = new System.Drawing.Size(46, 48);
            this.btnLuatChoi.TabIndex = 2;
            this.btnLuatChoi.Text = "?";
            this.btnLuatChoi.Click += new System.EventHandler(this.btnLuatChoi_Click);
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCauHoi.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCauHoi.Location = new System.Drawing.Point(3, 60);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(1274, 100);
            this.lblCauHoi.TabIndex = 1;
            this.lblCauHoi.Text = "Câu hỏi sẽ hiển thị ở đây";
            this.lblCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerLayout
            // 
            this.answerLayout.ColumnCount = 2;
            this.answerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerLayout.Controls.Add(this.btnDapAnA, 0, 0);
            this.answerLayout.Controls.Add(this.btnDapAnB, 1, 0);
            this.answerLayout.Controls.Add(this.btnDapAnC, 0, 1);
            this.answerLayout.Controls.Add(this.btnDapAnD, 1, 1);
            this.answerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerLayout.Location = new System.Drawing.Point(3, 163);
            this.answerLayout.Name = "answerLayout";
            this.answerLayout.RowCount = 2;
            this.answerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerLayout.Size = new System.Drawing.Size(1274, 514);
            this.answerLayout.TabIndex = 2;
            // 
            // btnDapAnA
            // 
            this.btnDapAnA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDapAnA.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDapAnA.Location = new System.Drawing.Point(3, 3);
            this.btnDapAnA.Name = "btnDapAnA";
            this.btnDapAnA.Size = new System.Drawing.Size(631, 251);
            this.btnDapAnA.TabIndex = 0;
            this.btnDapAnA.Text = "A. Đáp án A";
            this.btnDapAnA.Click += new System.EventHandler(this.btnDapAnA_Click);
            // 
            // btnDapAnB
            // 
            this.btnDapAnB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDapAnB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDapAnB.Location = new System.Drawing.Point(640, 3);
            this.btnDapAnB.Name = "btnDapAnB";
            this.btnDapAnB.Size = new System.Drawing.Size(631, 251);
            this.btnDapAnB.TabIndex = 1;
            this.btnDapAnB.Text = "B. Đáp án B";
            this.btnDapAnB.Click += new System.EventHandler(this.btnDapAnB_Click);
            // 
            // btnDapAnC
            // 
            this.btnDapAnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDapAnC.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDapAnC.Location = new System.Drawing.Point(3, 260);
            this.btnDapAnC.Name = "btnDapAnC";
            this.btnDapAnC.Size = new System.Drawing.Size(631, 251);
            this.btnDapAnC.TabIndex = 2;
            this.btnDapAnC.Text = "C. Đáp án C";
            this.btnDapAnC.Click += new System.EventHandler(this.btnDapAnC_Click);
            // 
            // btnDapAnD
            // 
            this.btnDapAnD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDapAnD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDapAnD.Location = new System.Drawing.Point(640, 260);
            this.btnDapAnD.Name = "btnDapAnD";
            this.btnDapAnD.Size = new System.Drawing.Size(631, 251);
            this.btnDapAnD.TabIndex = 3;
            this.btnDapAnD.Text = "D. Đáp án D";
            this.btnDapAnD.Click += new System.EventHandler(this.btnDapAnD_Click);
            // 
            // progressThoiGian
            // 
            this.progressThoiGian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressThoiGian.Location = new System.Drawing.Point(3, 683);
            this.progressThoiGian.Maximum = 300;
            this.progressThoiGian.Name = "progressThoiGian";
            this.progressThoiGian.Size = new System.Drawing.Size(1274, 24);
            this.progressThoiGian.TabIndex = 3;
            this.progressThoiGian.Value = 300;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.Location = new System.Drawing.Point(0, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(100, 23);
            this.lblThoiGian.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ChoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.mainLayout);
            this.Location = new System.Drawing.Point(0, 0);
            this.MinimumSize = new System.Drawing.Size(1024, 576);
            this.Name = "ChoiForm";
            this.Text = "Chơi câu hỏi";
            this.mainLayout.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.leftInfoPanel.ResumeLayout(false);
            this.leftInfoPanel.PerformLayout();
            this.answerLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}