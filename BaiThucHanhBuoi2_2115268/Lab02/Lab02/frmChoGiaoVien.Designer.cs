
namespace Lab02
{
    partial class frmChoGiaoVien
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
            this.gBTimTheo = new System.Windows.Forms.GroupBox();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdSDT = new System.Windows.Forms.RadioButton();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.gBTimTheo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBTimTheo
            // 
            this.gBTimTheo.Controls.Add(this.rdSDT);
            this.gBTimTheo.Controls.Add(this.rdHoTen);
            this.gBTimTheo.Controls.Add(this.rdMa);
            this.gBTimTheo.Location = new System.Drawing.Point(66, 54);
            this.gBTimTheo.Name = "gBTimTheo";
            this.gBTimTheo.Size = new System.Drawing.Size(547, 92);
            this.gBTimTheo.TabIndex = 0;
            this.gBTimTheo.TabStop = false;
            this.gBTimTheo.Text = "Tìm theo";
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Checked = true;
            this.rdMa.Location = new System.Drawing.Point(27, 36);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(84, 24);
            this.rdMa.TabIndex = 1;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Mã GV";
            this.rdMa.UseVisualStyleBackColor = true;
            this.rdMa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(221, 36);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(86, 24);
            this.rdHoTen.TabIndex = 1;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdSDT
            // 
            this.rdSDT.AutoSize = true;
            this.rdSDT.Location = new System.Drawing.Point(397, 36);
            this.rdSDT.Name = "rdSDT";
            this.rdSDT.Size = new System.Drawing.Size(127, 24);
            this.rdSDT.TabIndex = 1;
            this.rdSDT.Text = "Số điện thoại";
            this.rdSDT.UseVisualStyleBackColor = true;
            this.rdSDT.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(62, 206);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(59, 20);
            this.lblMaGV.TabIndex = 1;
            this.lblMaGV.Text = "Mã GV";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(203, 200);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(318, 26);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(538, 196);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 34);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // frmChoGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblMaGV);
            this.Controls.Add(this.gBTimTheo);
            this.Name = "frmChoGiaoVien";
            this.Text = "Tìm thông tin Giáo Viên";
            this.gBTimTheo.ResumeLayout(false);
            this.gBTimTheo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBTimTheo;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.RadioButton rdSDT;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnOK;
    }
}