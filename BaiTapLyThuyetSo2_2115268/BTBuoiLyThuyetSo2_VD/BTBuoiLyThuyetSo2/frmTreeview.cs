using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTBuoiLyThuyetSo2
{
    public partial class frmTreeview : Form
    {
        public frmTreeview()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void frmTreeview_Load(object sender, EventArgs e)
        {
            TreeNode rdNode, cNode;
            rdNode = this.treeViewThucVat.Nodes.Add("Các loại hoa");
            rdNode.ImageIndex = 0;

            cNode = new TreeNode(" Hoa Lan");
            cNode.ImageIndex = 1;
            rdNode.Nodes.Add(cNode);

            cNode = new TreeNode(" Hoa Hồng ", 2, 2);
            rdNode.Nodes.Add(cNode);

            rdNode = this.treeViewThucVat.Nodes.Add(" Trái cây");
            rdNode.ImageIndex = 3;

            cNode = new TreeNode("Trái Xoài");
            cNode.ImageIndex = 4;
            rdNode.Nodes.Add(cNode);

            cNode = new TreeNode(" Trái Mít");
            cNode.ImageIndex = 5;
            rdNode.Nodes.Add(cNode);


        }
    }
}
