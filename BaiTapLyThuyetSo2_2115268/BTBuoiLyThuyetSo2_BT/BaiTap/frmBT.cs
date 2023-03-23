using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class frmBT : Form
    {
        private object dtgDSNV;

        public frmBT()
        {
            InitializeComponent();
        }

        private void frmBT_Load(object sender, EventArgs e)
        {

        }
     
        private void lblMaNv_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void Reset()
        {
            txtHoten.Text = "";
            txtHinh.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
            mtbSoDT.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
