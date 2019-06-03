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
using System.Text;

namespace ProjetoStringWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // StringWriter - exemplo
            var sw = new StringWriter();
            sw.WriteLine("Linha 1");
            sw.WriteLine("Linha 2");
            sw.WriteLine("Linha 3");
            sw.WriteLine("Linha 4");
            //MessageBox.Show(sw.ToString());
            txtStrings.Text = sw.ToString();

            // StringReader - Exemplo
            string linha = null;
            string msg = null;
            StringReader sr = new StringReader(sw.ToString());
            while (true)
            {
                linha = sr.ReadLine();
                MessageBox.Show(linha);
                if (linha == null)
                    break;
                else
                    msg = msg + linha + Environment.NewLine;
            }
            txtStringReader.Text = msg;
        }
    }
}
