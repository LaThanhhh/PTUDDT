﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_ThietKeForm
{
    public partial class frmBai3 : Form
    {
        List<string> list = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            var tu = txtTuMoi.Text;
            var nghia = txtHienThiNghia.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);

            txtTuMoi.Focus();
            txtTuMoi.Text = "";
            txtNghiaCuaTu.Text = "";

            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            txtHienThiNghia.Text = nghia;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;

            txtHienThiNghia.Text = list[stt];
        }
    }
}
