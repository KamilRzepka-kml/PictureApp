using System;
using System.Collections.Generic;
using System.IO;
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

            var somePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"pictures");

            if (Directory.Exists(somePath))
            {
                openFileDialog.InitialDirectory = somePath;
            }
            else
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            }

            return openFileDialog;
        }

    }
}
