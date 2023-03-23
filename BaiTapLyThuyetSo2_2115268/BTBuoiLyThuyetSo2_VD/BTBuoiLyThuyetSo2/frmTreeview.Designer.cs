
namespace BTBuoiLyThuyetSo2
{
    partial class frmTreeview
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("HoaLan");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("HoaLoaKen");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("HoaDongTien");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CacLoaiHoa", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Cam");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quyt");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("DuaHau");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("QuaMongnuoc", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ThanhLong");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("NodeXoai");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("QuaThit", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("TraiCay", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode11});
            this.treeViewThucVat = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewThucVat
            // 
            this.treeViewThucVat.Location = new System.Drawing.Point(68, 37);
            this.treeViewThucVat.Name = "treeViewThucVat";
            treeNode1.Name = "NodeHoaLan";
            treeNode1.Text = "HoaLan";
            treeNode2.Name = "NodeHoaLoaKen";
            treeNode2.Text = "HoaLoaKen";
            treeNode3.Name = "NodeHoaDongTien";
            treeNode3.Text = "HoaDongTien";
            treeNode4.Name = "NodeCacLoaiHoa";
            treeNode4.Text = "CacLoaiHoa";
            treeNode5.Name = "NodeCam";
            treeNode5.Text = "Cam";
            treeNode6.Name = "NodeQuyt";
            treeNode6.Text = "Quyt";
            treeNode7.Name = "NodeDuaHau";
            treeNode7.Text = "DuaHau";
            treeNode8.Name = "NodeQuaMongNuoc";
            treeNode8.Text = "QuaMongnuoc";
            treeNode9.Name = "NodeThanhLong";
            treeNode9.Text = "ThanhLong";
            treeNode10.Name = "NodeXoai";
            treeNode10.Text = "NodeXoai";
            treeNode11.Name = "NodeQuaThit";
            treeNode11.Text = "QuaThit";
            treeNode12.Name = "NodeTraiCay";
            treeNode12.Text = "TraiCay";
            this.treeViewThucVat.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode12});
            this.treeViewThucVat.Size = new System.Drawing.Size(282, 274);
            this.treeViewThucVat.TabIndex = 0;
            this.treeViewThucVat.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // frmTreeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewThucVat);
            this.Name = "frmTreeview";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.frmTreeview_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewThucVat;
    }
}