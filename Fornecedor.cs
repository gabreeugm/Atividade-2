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
    public partial class Fornecedor : Form
    {
        Fornecedores forne = new Fornecedores();
        
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtFornecedor.Text == "" || txtCNPJ.Text == "" || txtCEP.Text == "" //se não tiver algum campo preenchido
                || txtRua.Text == "" || txtTelefone.Text == "" || txtEmail.Text == ""
                || txtcodigoPost.Text == "" || txtSite.Text == "" || txtRaastreio.Text == "" || txtEntregador.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Consultar.Enabled = true;
                forne.Fornecedor = txtFornecedor.Text;
                forne.CNPJ = txtCNPJ.Text;
                forne.Cep = txtCEP.Text;
                forne.Rua = txtRua.Text;
                forne.Telefone = txtTelefone.Text;
                forne.Email = txtEmail.Text;
                forne.CodigoPost = txtcodigoPost.Text;
                forne.Site = txtSite.Text;
                forne.Rastreio = txtRaastreio.Text;
                forne.Entregador = txtEntregador.Text;
                MessageBox.Show("Dados armazenados com sucesso!", "Prosseguir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtCEP.Clear();
            txtFornecedor.Clear();
            txtCNPJ.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtcodigoPost.Clear();
            txtSite.Clear();
            txtRaastreio.Clear();
            txtEntregador.Clear();
            MessageBox.Show("Dados Limpos", "Prosseguir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            string consulta = "\nFornecedor: " + forne.Fornecedor +
                              "\n -------------------------------------------" +
                              "\nCnpj: " + forne.CNPJ +
                                "\n -------------------------------------------" +
                              "\nCep: " + forne.Cep +
                                "\n -------------------------------------------" +
                              "\nRua: " + forne.Rua +
                                "\n -------------------------------------------" +
                              "\nTelefone: " + forne.Telefone +
                                "\n -------------------------------------------" +
                              "\nE-mail: " + forne.Email +
                                "\n -------------------------------------------" +
                              "\nCodg Postal: " + forne.CodigoPost +
                                "\n -------------------------------------------" +
                              "\nSite: " + forne.Site +
                                "\n -------------------------------------------" +
                              "\nCodg Rastreio: " + forne.Rastreio +
                              "\n -------------------------------------------"+
                              "\nEntregador: " + forne.Entregador;

            MessageBox.Show(consulta, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            var formPrincipal = new Principal();
            formPrincipal.Show();
            this.Hide();
        }
    }
}
