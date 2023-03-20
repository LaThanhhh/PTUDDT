
namespace Lab02
{
    partial class frmGiaoVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayDangSinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.mtxtSoDt = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbDanhSachMH = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbMonHocDay = new System.Windows.Forms.ListBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.linkLienHe = new System.Windows.Forms.LinkLabel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN GIÁO VIÊN KHOA CNTT\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ Tên\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh\r\n";
            // 
            // dtpNgayDangSinh
            // 
            this.dtpNgayDangSinh.Location = new System.Drawing.Point(189, 181);
            this.dtpNgayDangSinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgayDangSinh.Name = "dtpNgayDangSinh";
            this.dtpNgayDangSinh.Size = new System.Drawing.Size(194, 26);
            this.dtpNgayDangSinh.TabIndex = 6;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(189, 124);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(194, 26);
            this.txtHoten.TabIndex = 4;
            // 
            // cboMaSo
            // 
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cboMaSo.Location = new System.Drawing.Point(189, 73);
            this.cboMaSo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(194, 28);
            this.cboMaSo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giới tính\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số ĐT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(544, 78);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(71, 24);
            this.rdNam.TabIndex = 2;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam \r\n";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(657, 77);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(54, 24);
            this.rdNu.TabIndex = 3;
            this.rdNu.Text = "Nữ\r\n";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // mtxtSoDt
            // 
            this.mtxtSoDt.Location = new System.Drawing.Point(545, 124);
            this.mtxtSoDt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtSoDt.Name = "mtxtSoDt";
            this.mtxtSoDt.Size = new System.Drawing.Size(180, 26);
            this.mtxtSoDt.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(413, 181);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Địa chỉ mail\r\n";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(544, 178);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(181, 26);
            this.txtMail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngoại Ngữ";
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(189, 233);
            this.chklbNgoaiNgu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(178, 96);
            this.chklbNgoaiNgu.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 334);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Danh sách môn học";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(541, 334);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Môn học giáo viên dạy\r\n";
            // 
            // lbDanhSachMH
            // 
            this.lbDanhSachMH.FormattingEnabled = true;
            this.lbDanhSachMH.ItemHeight = 20;
            this.lbDanhSachMH.Items.AddRange(new object[] {
            "Tin học cơ sở ",
            "Lập trình cấu trúc CC++",
            "Cơ dở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng ANh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ thông tin",
            "Phân tíchTKHDT"});
            this.lbDanhSachMH.Location = new System.Drawing.Point(189, 371);
            this.lbDanhSachMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbDanhSachMH.Name = "lbDanhSachMH";
            this.lbDanhSachMH.Size = new System.Drawing.Size(178, 144);
            this.lbDanhSachMH.TabIndex = 9;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(402, 399);
            this.btnChon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(74, 35);
            this.btnChon.TabIndex = 11;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(402, 444);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 35);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbMonHocDay
            // 
            this.lbMonHocDay.FormattingEnabled = true;
            this.lbMonHocDay.ItemHeight = 20;
            this.lbMonHocDay.Location = new System.Drawing.Point(544, 371);
            this.lbMonHocDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbMonHocDay.Name = "lbMonHocDay";
            this.lbMonHocDay.Size = new System.Drawing.Size(208, 144);
            this.lbMonHocDay.TabIndex = 10;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Blue;
            this.btnLuu.Location = new System.Drawing.Point(338, 537);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(138, 48);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(544, 537);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 48);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(675, 537);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 48);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 624);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Website";
            // 
            // linkLienHe
            // 
            this.linkLienHe.AutoSize = true;
            this.linkLienHe.Location = new System.Drawing.Point(691, 624);
            this.linkLienHe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLienHe.Name = "linkLienHe";
            this.linkLienHe.Size = new System.Drawing.Size(61, 20);
            this.linkLienHe.TabIndex = 16;
            this.linkLienHe.TabStop = true;
            this.linkLienHe.Text = "Liên hệ";
            this.linkLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLienHe_LinkClicked);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Location = new System.Drawing.Point(174, 537);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(138, 48);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.Blue;
            this.btnTim.Location = new System.Drawing.Point(18, 537);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(138, 48);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.linkLienHe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbMonHocDay);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbDanhSachMH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chklbNgoaiNgu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtSoDt);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.dtpNgayDangSinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmGiaoVien";
            this.Text = "Giáo Viên";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayDangSinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.MaskedTextBox mtxtSoDt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbDanhSachMH;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox lbMonHocDay;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel linkLienHe;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
    }
}

