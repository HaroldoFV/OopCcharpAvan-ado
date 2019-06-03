using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileInformation
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openDlg.ShowDialog() == DialogResult.OK)
                ShowFileInfo(openDlg.FileName);
        }

        private void ShowFileInfo(string FileName)
        {
            Text = FileName;
            FileInfo info = new FileInfo(FileName);
            txtCriacao.Text = info.CreationTime.ToString();
            txtAcesso.Text = info.LastAccessTime.ToString();
            txtModificacao.Text = info.LastWriteTime.ToString();
            txtNome.Text = info.Name;
            txtDiretorio.Text = info.Directory.FullName;
            txtTamanho.Text = info.Length.ToString();
            txtExtensao.Text = info.Extension;
            cbReadOnly.Checked = info.IsReadOnly;
            txtAtributos.Text = info.Attributes.ToString();
        }
    }
}
