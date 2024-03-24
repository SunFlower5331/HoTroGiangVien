namespace GUI
{
    partial class FormLogin
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
            this.taikhoan = new System.Windows.Forms.Label();
            this.matkhau = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.checkBoxHTMK = new System.Windows.Forms.CheckBox();
            this.dangnhap = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taikhoan
            // 
            this.taikhoan.AutoSize = true;
            this.taikhoan.BackColor = System.Drawing.Color.Transparent;
            this.taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taikhoan.ForeColor = System.Drawing.Color.Black;
            this.taikhoan.Location = new System.Drawing.Point(13, 55);
            this.taikhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taikhoan.Name = "taikhoan";
            this.taikhoan.Size = new System.Drawing.Size(87, 20);
            this.taikhoan.TabIndex = 1;
            this.taikhoan.Text = "Tài khoản";
            // 
            // matkhau
            // 
            this.matkhau.AutoSize = true;
            this.matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matkhau.Location = new System.Drawing.Point(18, 124);
            this.matkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.matkhau.Name = "matkhau";
            this.matkhau.Size = new System.Drawing.Size(83, 20);
            this.matkhau.TabIndex = 2;
            this.matkhau.Text = "Mật khẩu";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(115, 46);
            this.user.Margin = new System.Windows.Forms.Padding(2);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(228, 29);
            this.user.TabIndex = 3;
            // 
            // pass
            // 
            this.pass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(115, 114);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(228, 29);
            this.pass.TabIndex = 4;
            this.pass.UseSystemPasswordChar = true;
            // 
            // checkBoxHTMK
            // 
            this.checkBoxHTMK.AutoSize = true;
            this.checkBoxHTMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHTMK.Location = new System.Drawing.Point(115, 174);
            this.checkBoxHTMK.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxHTMK.Name = "checkBoxHTMK";
            this.checkBoxHTMK.Size = new System.Drawing.Size(109, 17);
            this.checkBoxHTMK.TabIndex = 5;
            this.checkBoxHTMK.Text = "Hiển thị mật khẩu";
            this.checkBoxHTMK.UseVisualStyleBackColor = true;
            this.checkBoxHTMK.CheckedChanged += new System.EventHandler(this.checkBoxHTMK_CheckedChanged);
            // 
            // dangnhap
            // 
            this.dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dangnhap.Location = new System.Drawing.Point(231, 251);
            this.dangnhap.Name = "dangnhap";
            this.dangnhap.Size = new System.Drawing.Size(112, 32);
            this.dangnhap.TabIndex = 9;
            this.dangnhap.Text = "   Đăng nhập";
            this.dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dangnhap.UseVisualStyleBackColor = false;
            this.dangnhap.Click += new System.EventHandler(this.dangnhap_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.SystemColors.Info;
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.thoat.Location = new System.Drawing.Point(115, 251);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(97, 32);
            this.thoat.TabIndex = 10;
            this.thoat.Text = "Đăng ký";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(63, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 288);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUII.Properties.Resources._5087579;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.thoat);
            this.panel1.Controls.Add(this.matkhau);
            this.panel1.Controls.Add(this.dangnhap);
            this.panel1.Controls.Add(this.taikhoan);
            this.panel1.Controls.Add(this.checkBoxHTMK);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.user);
            this.panel1.Location = new System.Drawing.Point(369, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 343);
            this.panel1.TabIndex = 12;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label taikhoan;
        private System.Windows.Forms.Label matkhau;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.CheckBox checkBoxHTMK;
        private System.Windows.Forms.Button dangnhap;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}

