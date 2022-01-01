
namespace GUI_QLTHUVIEN
{
    partial class frmMuonsach
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnMuonsach = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMasach = new System.Windows.Forms.ComboBox();
            this.dtNgaymuon = new System.Windows.Forms.DateTimePicker();
            this.cbbMathe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 26);
            this.label5.TabIndex = 79;
            this.label5.Text = "Mã thẻ : ";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(294, 287);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 67);
            this.btnHuy.TabIndex = 86;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnMuonsach
            // 
            this.btnMuonsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonsach.Location = new System.Drawing.Point(90, 287);
            this.btnMuonsach.Name = "btnMuonsach";
            this.btnMuonsach.Size = new System.Drawing.Size(154, 67);
            this.btnMuonsach.TabIndex = 84;
            this.btnMuonsach.Text = "Mượn sách";
            this.btnMuonsach.UseVisualStyleBackColor = true;
            this.btnMuonsach.Click += new System.EventHandler(this.btnMuonsach_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(43, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 26);
            this.label9.TabIndex = 73;
            this.label9.Text = "Mã sách : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(43, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 26);
            this.label10.TabIndex = 74;
            this.label10.Text = "Ngày mượn : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(185, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 72;
            this.label2.Text = "Mượn sách";
            // 
            // cbbMasach
            // 
            this.cbbMasach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMasach.FormattingEnabled = true;
            this.cbbMasach.Location = new System.Drawing.Point(238, 98);
            this.cbbMasach.Name = "cbbMasach";
            this.cbbMasach.Size = new System.Drawing.Size(255, 34);
            this.cbbMasach.TabIndex = 87;
            // 
            // dtNgaymuon
            // 
            this.dtNgaymuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaymuon.Location = new System.Drawing.Point(238, 153);
            this.dtNgaymuon.Name = "dtNgaymuon";
            this.dtNgaymuon.Size = new System.Drawing.Size(255, 32);
            this.dtNgaymuon.TabIndex = 88;
            // 
            // cbbMathe
            // 
            this.cbbMathe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMathe.FormattingEnabled = true;
            this.cbbMathe.Location = new System.Drawing.Point(238, 211);
            this.cbbMathe.Name = "cbbMathe";
            this.cbbMathe.Size = new System.Drawing.Size(255, 34);
            this.cbbMathe.TabIndex = 89;
            // 
            // frmMuonsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 397);
            this.Controls.Add(this.cbbMathe);
            this.Controls.Add(this.dtNgaymuon);
            this.Controls.Add(this.cbbMasach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnMuonsach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Name = "frmMuonsach";
            this.Text = "frmMuonsach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnMuonsach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMasach;
        private System.Windows.Forms.DateTimePicker dtNgaymuon;
        private System.Windows.Forms.ComboBox cbbMathe;
    }
}