
namespace GUI_QLTHUVIEN
{
    partial class GUI_Sach
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuQuanlysach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlythe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlymuontrasach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlydausach = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQuanlyloai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQuanlysach
            // 
            this.mnuQuanlysach.Name = "mnuQuanlysach";
            this.mnuQuanlysach.Size = new System.Drawing.Size(106, 24);
            this.mnuQuanlysach.Text = "Quản lý sách";
            this.mnuQuanlysach.Click += new System.EventHandler(this.mnuQuanlysach_Click);
            // 
            // mnuQuanlythe
            // 
            this.mnuQuanlythe.Name = "mnuQuanlythe";
            this.mnuQuanlythe.Size = new System.Drawing.Size(98, 24);
            this.mnuQuanlythe.Text = "Quản lý thẻ";
            this.mnuQuanlythe.Click += new System.EventHandler(this.mnuQuanlythe_Click);
            // 
            // mnuQuanlymuontrasach
            // 
            this.mnuQuanlymuontrasach.Name = "mnuQuanlymuontrasach";
            this.mnuQuanlymuontrasach.Size = new System.Drawing.Size(171, 24);
            this.mnuQuanlymuontrasach.Text = "Quản lý mượn trả sách";
            this.mnuQuanlymuontrasach.Click += new System.EventHandler(this.mnuQuanlymuontrasach_Click);
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose,
            this.mnuDangnhap,
            this.mnuDangxuat});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(70, 24);
            this.mnuSystem.Text = "System";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(224, 26);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuQuanlydausach
            // 
            this.mnuQuanlydausach.Name = "mnuQuanlydausach";
            this.mnuQuanlydausach.Size = new System.Drawing.Size(135, 24);
            this.mnuQuanlydausach.Text = "Quản lý đầu sách";
            this.mnuQuanlydausach.Click += new System.EventHandler(this.mnuQuanlydausach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuQuanlydausach,
            this.mnuQuanlysach,
            this.mnuQuanlyloai,
            this.mnuQuanlythe,
            this.mnuQuanlymuontrasach,
            this.mnuThongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuQuanlyloai
            // 
            this.mnuQuanlyloai.Name = "mnuQuanlyloai";
            this.mnuQuanlyloai.Size = new System.Drawing.Size(135, 24);
            this.mnuQuanlyloai.Text = "Quản lý loại sách";
            this.mnuQuanlyloai.Click += new System.EventHandler(this.mnuQuanlyloai_Click);
            // 
            // mnuDangnhap
            // 
            this.mnuDangnhap.Name = "mnuDangnhap";
            this.mnuDangnhap.Size = new System.Drawing.Size(224, 26);
            this.mnuDangnhap.Text = "Đăng nhập";
            this.mnuDangnhap.Click += new System.EventHandler(this.mnuDangnhap_Click);
            // 
            // mnuDangxuat
            // 
            this.mnuDangxuat.Name = "mnuDangxuat";
            this.mnuDangxuat.Size = new System.Drawing.Size(224, 26);
            this.mnuDangxuat.Text = "Đăng xuất";
            this.mnuDangxuat.Click += new System.EventHandler(this.mnuDangxuat_Click);
            // 
            // mnuThongke
            // 
            this.mnuThongke.Name = "mnuThongke";
            this.mnuThongke.Size = new System.Drawing.Size(218, 24);
            this.mnuThongke.Text = "Thống kê báo cáo mượn sách";
            this.mnuThongke.Click += new System.EventHandler(this.mnuThongke_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(162, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MƯỢN TRẢ SÁCH THƯ VIỆN";
            // 
            // GUI_Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 423);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GUI_Sach";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.GUI_Sach_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mnuQuanlysach;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlythe;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlymuontrasach;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlydausach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanlyloai;
        private System.Windows.Forms.ToolStripMenuItem mnuDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnuDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThongke;
        private System.Windows.Forms.Label label1;
    }
}

