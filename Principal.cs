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
        //Login form2 = new Login(); //Tela login
        Cadastro form4 = new Cadastro(); //Tela cadastro
        Endereco form5 = new Endereco();
        Cadastro_Produtos form6 = new Cadastro_Produtos();
        Fornecedor form7 = new Fornecedor();

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
            this.Hide(); //Fecha forms
            form5.ShowDialog(); //Apresenta form endereço
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form6.ShowDialog();

        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            form7.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
