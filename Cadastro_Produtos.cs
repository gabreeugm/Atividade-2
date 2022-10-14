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
    public partial class Cadastro_Produtos : Form
    {
        ClasseProduto prod = new ClasseProduto();   // Criação de objeto
        public Cadastro_Produtos()
        {
            InitializeComponent();
        }

        private void Cadastro_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)  // Fechar Forms
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)  
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||    // Condição para que cadastre
                textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Erro cadastrando o produto. Por favor insira corretamente as informações.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();

            }

            else       // Atribuindo valores
            {
                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);          
                prod.setNOME_PROD(textBox1.Text);                
                prod.setDESC(textBox2.Text);
                prod.setBUYPRICE(float.Parse(textBox3.Text));
                prod.setSELLPRICE(float.Parse(textBox4.Text));
                prod.setMARCA(textBox5.Text);
                prod.setESTQ(int.Parse(textBox6.Text));
                prod.setFORN(textBox7.Text);
                prod.setCORES(textBox8.Text);
                prod.setCOD(textBox9.Text);
                prod.setSIZE(textBox10.Text);               
            }


        }

        private void button3_Click(object sender, EventArgs e)    // Apresenta Valores
        {

            string consultar = "Nome do Produto: " + prod.getNOME_PROD() +
                               "\n---------------------------------------"  +
                               "\nDescrição: " + prod.getDESC() +
                               "\n---------------------------------------" +
                               "\nPreço de Compra: R$" + prod.getBUYPRICE() +
                               "\n---------------------------------------" +
                               "\nPreço de Venda: R$" + prod.getSELLPRICE() +
                               "\n---------------------------------------" +
                               "\nMarca: " + prod.getMARCA() +
                               "\n---------------------------------------" +
                               "\nQuantidade em Estoque: " + prod.getESTQ() +
                               "\n---------------------------------------" +
                               "\nFornecedor: " + prod.getFORN() +
                               "\n---------------------------------------" +
                               "\nCores: " + prod.getCORES() +
                               "\n---------------------------------------" +
                               "\nCódigo: " + prod.getCOD() +
                               "\n---------------------------------------" +
                               "\nTamanho: " + prod.getSIZE();


            MessageBox.Show(consultar, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void button1_Click(object sender, EventArgs e) // Limpa informações das textbox
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();

        }
    }
}
