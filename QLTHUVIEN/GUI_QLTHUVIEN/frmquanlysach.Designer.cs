
namespace GUI_QLTHUVIEN
{
    partial class frmquanlysach
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.btnThemsach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoasach = new System.Windows.Forms.Button();
            this.btnSuasach = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.txtNhaxuatban = new System.Windows.Forms.TextBox();
            this.txtTacgia = new System.Windows.Forms.TextBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbMadausach = new System.Windows.Forms.ComboBox();
            this.txtDamuon = new System.Windows.Forms.TextBox();
            this.txtMatsach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(593, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sách";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(66, 140);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(1180, 205);
            this.dgvSach.TabIndex = 1;
            this.dgvSach.Click += new System.EventHandler(this.dgvSach_Click);
            // 
            // btnThemsach
            // 
            this.btnThemsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemsach.Location = new System.Drawing.Point(202, 581);
            this.btnThemsach.Name = "btnThemsach";
            this.btnThemsach.Size = new System.Drawing.Size(154, 67);
            this.btnThemsach.TabIndex = 2;
            this.btnThemsach.Text = "Thêm sách";
            this.btnThemsach.UseVisualStyleBackColor = true;
            this.btnThemsach.Click += new System.EventHandler(this.btnThemsach_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tìm kiếm theo tên sách, tác giả hoặc nhà xuất bản : ";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(657, 74);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(438, 32);
            this.txtTimkiem.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(1151, 67);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(95, 46);
            this.btnTimkiem.TabIndex = 5;
            this.btnTimkiem.Text = "Tìm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoasach
            // 
            this.btnXoasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoasach.Location = new System.Drawing.Point(500, 581);
            this.btnXoasach.Name = "btnXoasach";
            this.btnXoasach.Size = new System.Drawing.Size(154, 67);
            this.btnXoasach.TabIndex = 6;
            this.btnXoasach.Text = "Xoá sách";
            this.btnXoasach.UseVisualStyleBackColor = true;
            this.btnXoasach.Click += new System.EventHandler(this.btnXoasach_Click);
            // 
            // btnSuasach
            // 
            this.btnSuasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuasach.Location = new System.Drawing.Point(801, 581);
            this.btnSuasach.Name = "btnSuasach";
            this.btnSuasach.Size = new System.Drawing.Size(154, 67);
            this.btnSuasach.TabIndex = 7;
            this.btnSuasach.Text = "Sửa sách";
            this.btnSuasach.UseVisualStyleBackColor = true;
            this.btnSuasach.Click += new System.EventHandler(this.btnSuasach_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(1094, 581);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(154, 67);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã sách : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(524, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên sách : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1006, 449);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Đã mượn : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1006, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mất sách : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(519, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tình trạng : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(519, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nhà xuất bản: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(61, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tác giả : ";
            // 
            // txtMasach
            // 
            this.txtMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMasach.Location = new System.Drawing.Point(228, 389);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.ReadOnly = true;
            this.txtMasach.Size = new System.Drawing.Size(213, 32);
            this.txtMasach.TabIndex = 16;
            // 
            // txtNhaxuatban
            // 
            this.txtNhaxuatban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaxuatban.Location = new System.Drawing.Point(678, 386);
            this.txtNhaxuatban.Name = "txtNhaxuatban";
            this.txtNhaxuatban.Size = new System.Drawing.Size(229, 32);
            this.txtNhaxuatban.TabIndex = 17;
            // 
            // txtTacgia
            // 
            this.txtTacgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTacgia.Location = new System.Drawing.Point(228, 443);
            this.txtTacgia.Name = "txtTacgia";
            this.txtTacgia.Size = new System.Drawing.Size(213, 32);
            this.txtTacgia.TabIndex = 18;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhtrang.Location = new System.Drawing.Point(678, 443);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(229, 32);
            this.txtTinhtrang.TabIndex = 19;
            // 
            // txtTensach
            // 
            this.txtTensach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensach.Location = new System.Drawing.Point(678, 500);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(568, 32);
            this.txtTensach.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 503);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 26);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã đầu sách : ";
            // 
            // cbbMadausach
            // 
            this.cbbMadausach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMadausach.FormattingEnabled = true;
            this.cbbMadausach.Location = new System.Drawing.Point(228, 500);
            this.cbbMadausach.Name = "cbbMadausach";
            this.cbbMadausach.Size = new System.Drawing.Size(213, 34);
            this.cbbMadausach.TabIndex = 24;
            // 
            // txtDamuon
            // 
            this.txtDamuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDamuon.Location = new System.Drawing.Point(1140, 446);
            this.txtDamuon.Name = "txtDamuon";
            this.txtDamuon.Size = new System.Drawing.Size(108, 32);
            this.txtDamuon.TabIndex = 25;
            // 
            // txtMatsach
            // 
            this.txtMatsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatsach.Location = new System.Drawing.Point(1140, 389);
            this.txtMatsach.Name = "txtMatsach";
            this.txtMatsach.Size = new System.Drawing.Size(108, 32);
            this.txtMatsach.TabIndex = 26;
            // 
            // frmquanlysach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 759);
            this.Controls.Add(this.txtMatsach);
            this.Controls.Add(this.txtDamuon);
            this.Controls.Add(this.cbbMadausach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTensach);
            this.Controls.Add(this.txtTinhtrang);
            this.Controls.Add(this.txtTacgia);
            this.Controls.Add(this.txtNhaxuatban);
            this.Controls.Add(this.txtMasach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuasach);
            this.Controls.Add(this.btnXoasach);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThemsach);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.label1);
            this.Name = "frmquanlysach";
            this.Text = "frmquanlysach";
            this.Activated += new System.EventHandler(this.frmquanlysach_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Button btnThemsach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoasach;
        private System.Windows.Forms.Button btnSuasach;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.TextBox txtNhaxuatban;
        private System.Windows.Forms.TextBox txtTacgia;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbMadausach;
        private System.Windows.Forms.TextBox txtDamuon;
        private System.Windows.Forms.TextBox txtMatsach;
    }
}