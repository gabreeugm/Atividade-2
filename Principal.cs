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
    public partial class Principal : Form
    {
         //Tela login
        Cadastro form4 = new Cadastro(); //Tela cadastro
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); //Fecha forms
            form4.ShowDialog(); //Apresenta form cadastro
        }

        private void endereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
