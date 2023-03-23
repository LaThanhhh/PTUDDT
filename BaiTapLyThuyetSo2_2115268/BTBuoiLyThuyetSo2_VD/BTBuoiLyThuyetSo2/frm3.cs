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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void frm3_Load(object sender, EventArgs e)
        {
            if(MessageBox.Show(" Lỗi chương trình, bạn muốn thoát?", " Error",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error)==DialogResult.OK)
            {
                Application.Exit();
            }    
       
        }
    }
}
