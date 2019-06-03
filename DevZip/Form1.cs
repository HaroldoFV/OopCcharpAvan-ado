using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevZip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var path = dlg.SelectedPath;
                txtSource.Text = path;

                foreach (var arq in Directory.GetFiles(path))
                {
                    lstArquivos.Items.Add(arq);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = dlg.SelectedPath;
            }
        }

        private void btnCompactar_Click(object sender, EventArgs e)
        {
            var pathToZip = txtSource.Text;
            var zipToPath = txtTarget.Text;
            var fileName = txtFileName.Text;
            ZipFile.CreateFromDirectory(pathToZip, fileName);
            MessageBox.Show("Arquivo zipado com sucesso");
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
                txtFileName.Text = dlgSave.FileName;
        }
    }
}
