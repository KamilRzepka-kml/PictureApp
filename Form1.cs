using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LastImage();
        }
        private void LastImage()
        {
            string lastImagePath = Properties.Settings.Default.LastImagePath;
            if (!string.IsNullOrEmpty(lastImagePath) && System.IO.File.Exists(lastImagePath))
            {
                pcbZdjecie.Load(lastImagePath);
            }
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var addPicture = new ImageFileDialog();
            //    OpenFileDialog openFileDialog = addPicture.CreateDialog();

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        pcbZdjecie.Load(openFileDialog.FileName);
            //        Properties.Settings.Default.LastImagePath = openFileDialog.FileName;
            //        Properties.Settings.Default.Save();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            var addPicture = new ImageFileDialog();
            OpenFileDialog openFileDialog = addPicture.CreateDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pcbZdjecie.Load(openFileDialog.FileName);
                Properties.Settings.Default.LastImagePath = openFileDialog.FileName;
                Properties.Settings.Default.Save();
            }
            openFileDialog.Dispose();
        }

        private void btnDelPic_Click(object sender, EventArgs e)
        {

            pcbZdjecie = null;
            Properties.Settings.Default.LastImagePath = string.Empty;
            Properties.Settings.Default.Save();
        }
    }
}
