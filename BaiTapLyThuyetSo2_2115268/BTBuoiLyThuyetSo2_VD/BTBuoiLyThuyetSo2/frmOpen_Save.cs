using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTBuoiLyThuyetSo2
{
    public partial class frmOpen_Save : Form
    {
        private object openFiledlg;
        private object saveFiledlg;

        public frmOpen_Save()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFiledlg.Title = "Open Dialog";
           openFiledlg.Multiselect = true;
            openFiledlg.Filter = " Image File ( JPEG, GIF, BMP, etc.)|"
                + "*.jpg;*.jpeg;*.gif;*.tif;*.png|"
                + "JEG file (*.jpg;*.jeg)|*.jpg;*.jpeg|"
                + "GIF files (*.gif)|*.gif|BMP files (*.bmp)|*.bmp|"
                + "TIFF files (*.tif;*.tiff)|*.tif;*.tiff|"
                + "PNG files (*.png)|*.png| All flies (*.*)|*.*";
            if (openFiledlg.ShowDiaLog() == DialogResult.OK)
            {
                string[] filenames = openFiledlg.FileNames;
                for (int i = 0; i < filenames.Length; i++)
                    this.lvListFile.Items.Add(new ListViewItem(filenames[i]));

            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFiledlg.Title = "Save file..";
            saveFiledlg.Filter = " Image Files ( JPEG, BMP, GIF,..)|(*.jpeg;*.jpg;)|"
                + "Bitmap files (*.nmp)|*.bmp| All files (*.*)|*.*";
            if (saveFiledlg.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    Image im = pbImage.Image;
                    im.Save(saveFiledlg.FileName, ImageFormat.Bmp);
                    
                }
                catch { }
            }
        }

        private void lvListFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lvListFile.SelectedItems.Count - 1;
            if (i>=0)
            {
                ListViewItem lvitem = lvListFile.SelectedItems[0];
                this.pbImage.ImageLocation = lvitem.Text;
            }
        }
    }
}
