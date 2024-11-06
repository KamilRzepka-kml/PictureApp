using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureApp
{
    internal class ImageFileDialog
    {
        public OpenFileDialog CreateDialog()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\rzepe\OneDrive\Pulpit\Informatyka\Programowanie obiektowe\kurs Kazik\PictureApp";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            return openFileDialog;
        }

    }
}
