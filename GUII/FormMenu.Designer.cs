namespace GUII
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lichday = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.thongtincanhan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.them = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.luong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hanhd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sohd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.diachi = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sdt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thongkevabaocao = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsdangnhap = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbdate = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnext = new System.Windows.Forms.Button();
            this.btprevious = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.lichday.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.thongtincanhan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.lichday);
            this.tabControl1.Controls.Add(this.thongtincanhan);
            this.tabControl1.Controls.Add(this.thongkevabaocao);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.lsdangnhap);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 692);
            this.tabControl1.TabIndex = 4;
            // 
            // lichday
            // 
            this.lichday.Controls.Add(this.panel1);
            this.lichday.Controls.Add(this.dataGridView6);
            this.lichday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lichday.Location = new System.Drawing.Point(4, 26);
            this.lichday.Margin = new System.Windows.Forms.Padding(2);
            this.lichday.Name = "lichday";
            this.lichday.Padding = new System.Windows.Forms.Padding(2);
            this.lichday.Size = new System.Drawing.Size(1276, 662);
            this.lichday.TabIndex = 0;
            this.lichday.Text = "Lịch dạy";
            this.lichday.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbdate);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.btnext);
            this.panel1.Controls.Add(this.btprevious);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 686);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(0, 5);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 24;
            this.dataGridView6.Size = new System.Drawing.Size(1309, 699);
            this.dataGridView6.TabIndex = 9;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // thongtincanhan
            // 
            this.thongtincanhan.Controls.Add(this.groupBox1);
            this.thongtincanhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thongtincanhan.Location = new System.Drawing.Point(4, 26);
            this.thongtincanhan.Margin = new System.Windows.Forms.Padding(2);
            this.thongtincanhan.Name = "thongtincanhan";
            this.thongtincanhan.Padding = new System.Windows.Forms.Padding(2);
            this.thongtincanhan.Size = new System.Drawing.Size(1274, 676);
            this.thongtincanhan.TabIndex = 1;
            this.thongtincanhan.Text = "Thông tin cá nhân";
            this.thongtincanhan.UseVisualStyleBackColor = true;
            this.thongtincanhan.Click += new System.EventHandler(this.thongtincanhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.luong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.hanhd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.sohd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sdt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(277, 109);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(664, 369);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // them
            // 
            this.them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(340, 202);
            this.them.Margin = new System.Windows.Forms.Padding(2);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(73, 26);
            this.them.TabIndex = 16;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            // 
            // luu
            // 
            this.luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luu.Location = new System.Drawing.Point(550, 202);
            this.luu.Margin = new System.Windows.Forms.Padding(2);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(70, 26);
            this.luu.TabIndex = 15;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = true;
            // 
            // sua
            // 
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(446, 202);
            this.sua.Margin = new System.Windows.Forms.Padding(2);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(73, 26);
            this.sua.TabIndex = 14;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = true;
            // 
            // luong
            // 
            this.luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luong.Location = new System.Drawing.Point(118, 150);
            this.luong.Margin = new System.Windows.Forms.Padding(2);
            this.luong.Name = "luong";
            this.luong.Size = new System.Drawing.Size(186, 24);
            this.luong.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(14, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Lương theo giờ";
            // 
            // hanhd
            // 
            this.hanhd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hanhd.Location = new System.Drawing.Point(464, 109);
            this.hanhd.Margin = new System.Windows.Forms.Padding(2);
            this.hanhd.Name = "hanhd";
            this.hanhd.Size = new System.Drawing.Size(186, 24);
            this.hanhd.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(328, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ngày hết hạn HD";
            // 
            // sohd
            // 
            this.sohd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sohd.Location = new System.Drawing.Point(117, 111);
            this.sohd.Margin = new System.Windows.Forms.Padding(2);
            this.sohd.Name = "sohd";
            this.sohd.Size = new System.Drawing.Size(186, 24);
            this.sohd.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(14, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số hợp đồng";
            // 
            // diachi
            // 
            this.diachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.diachi.Location = new System.Drawing.Point(464, 69);
            this.diachi.Margin = new System.Windows.Forms.Padding(2);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(186, 24);
            this.diachi.TabIndex = 7;
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.email.Location = new System.Drawing.Point(464, 29);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(186, 24);
            this.email.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(328, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa chỉ\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(328, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // sdt
            // 
            this.sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sdt.Location = new System.Drawing.Point(117, 72);
            this.sdt.Margin = new System.Windows.Forms.Padding(2);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(186, 24);
            this.sdt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số điện thoại";
            // 
            // hoten
            // 
            this.hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.hoten.Location = new System.Drawing.Point(117, 31);
            this.hoten.Margin = new System.Windows.Forms.Padding(2);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(186, 24);
            this.hoten.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên ";
            // 
            // thongkevabaocao
            // 
            this.thongkevabaocao.Location = new System.Drawing.Point(4, 26);
            this.thongkevabaocao.Margin = new System.Windows.Forms.Padding(2);
            this.thongkevabaocao.Name = "thongkevabaocao";
            this.thongkevabaocao.Size = new System.Drawing.Size(1274, 676);
            this.thongkevabaocao.TabIndex = 2;
            this.thongkevabaocao.Text = "Thống kê và báo cáo";
            this.thongkevabaocao.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1274, 676);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Tính tiền lương";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsdangnhap
            // 
            this.lsdangnhap.Location = new System.Drawing.Point(4, 26);
            this.lsdangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.lsdangnhap.Name = "lsdangnhap";
            this.lsdangnhap.Size = new System.Drawing.Size(1274, 676);
            this.lsdangnhap.TabIndex = 4;
            this.lsdangnhap.Text = "Lịch sử đăng nhập";
            this.lsdangnhap.UseVisualStyleBackColor = true;
            // 
            // lbdate
            // 
            this.lbdate.AutoSize = true;
            this.lbdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbdate.Location = new System.Drawing.Point(512, 6);
            this.lbdate.Name = "lbdate";
            this.lbdate.Size = new System.Drawing.Size(195, 31);
            this.lbdate.TabIndex = 28;
            this.lbdate.Text = "MONTH YEAR";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1250, 503);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1126, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Staturday";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(969, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 22;
            this.label16.Text = "Friday";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(790, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 16);
            this.label17.TabIndex = 26;
            this.label17.Text = "Thursday";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(577, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 16);
            this.label18.TabIndex = 25;
            this.label18.Text = "Wednessday";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(391, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 24;
            this.label19.Text = "Tuesday";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(232, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 23;
            this.label20.Text = "MonDay";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(81, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 16);
            this.label21.TabIndex = 20;
            this.label21.Text = "SunDay";
            // 
            // btnext
            // 
            this.btnext.Location = new System.Drawing.Point(1167, 609);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(99, 28);
            this.btnext.TabIndex = 19;
            this.btnext.Text = "Next";
            this.btnext.UseVisualStyleBackColor = true;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btprevious
            // 
            this.btprevious.Location = new System.Drawing.Point(1021, 609);
            this.btprevious.Name = "btprevious";
            this.btprevious.Size = new System.Drawing.Size(100, 28);
            this.btprevious.TabIndex = 18;
            this.btprevious.Text = "Previous";
            this.btprevious.UseVisualStyleBackColor = true;
            this.btprevious.Click += new System.EventHandler(this.btprevious_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 730);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.tabControl1.ResumeLayout(false);
            this.lichday.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.thongtincanhan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage lichday;
        private System.Windows.Forms.TabPage thongtincanhan;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage thongkevabaocao;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage lsdangnhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.TextBox luong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hanhd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sohd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btprevious;
    }
}