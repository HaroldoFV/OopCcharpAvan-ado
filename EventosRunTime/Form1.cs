using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosRunTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarButtonEmRunTime_Click(object sender, EventArgs e)
        {
            var bt = new Button();
            bt.Parent = this;
            this.Controls.Add(bt);
            bt.Text = "Clique aqui";
            bt.Location = new System.Drawing.Point(96, 80);
            bt.Click += new EventHandler(bt_Click);// atribuito o metodo ao evento - apontando para um metodo
            //bt.Click += bt_Click;// atribuito o metodo ao evento - apontando para um metodo
            bt.Click += delegate (object s, EventArgs ea)
            {
                //método anônimo
                MessageBox.Show("Olá Mundo!");
            };
            bt.Click += (s, ea) => MessageBox.Show("Hello People");
        }

        private void bt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!!!");
        }
    }
}
