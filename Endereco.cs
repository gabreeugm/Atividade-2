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

        ClasseEndereco endereco = new ClasseEndereco();

        public Endereco()
        {
            InitializeComponent();
        }

        private void Endereco_Load(object sender, EventArgs e)
        {

        }


        private void label13_Click(object sender, EventArgs e)
        {
            //botão de voltar a página
            var formPrincipal = new Principal();
            formPrincipal.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
               //botão de fechar 
              Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mensagem de aviso para preencher os campos
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
               textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" )
            {
                MessageBox.Show("Preencha Todos os campos para continuar", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                endereco.logradouro = textBox1.Text;
                endereco.numero = int.Parse(textBox2.Text);
                endereco.bairro = textBox3.Text;
                endereco.cep = textBox4.Text;
                endereco.complemento = textBox5.Text;
                endereco.cidade = textBox6.Text;
                endereco.estado = textBox7.Text;
                endereco.ponto_ref = textBox8.Text;
                endereco.horario_entrega = comboBox1.Text;

                MessageBox.Show("Os dados foram salvos !", "Conluído", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }




        }   

    }
}
