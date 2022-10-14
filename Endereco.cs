using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_2
{
    public partial class Endereco : Form
    {
        public Endereco()
        {
            InitializeComponent();
        }

        private void Endereco_Load(object sender, EventArgs e)
        {

        }


        private void label13_Click(object sender, EventArgs e)
        {
            var formPrincipal = new Principal();
            formPrincipal.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
