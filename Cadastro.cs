﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade_1;

namespace Atividade_2
{
    public partial class Cadastro : Form
    {
        ClasseCadastro cadastro = new ClasseCadastro();
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" //se não tiver algum campo preenchido
                || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == ""
                || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || textBox10.Text == "")
            {
                MessageBox.Show("Por favor preencha os campos corretamente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else //senão
            {
                if (textBox5.Text != textBox6.Text) //se a senha e a confirmação de senha forem divergentes
                {
                    MessageBox.Show("As senhas não coincidem!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else //senão
                {
                    //salvar
                    cadastro.setNOME(textBox1.Text);
                    cadastro.setTELEFONE(textBox2.Text);
                    cadastro.setCELULAR(textBox3.Text);
                    cadastro.setEMAIL(textBox4.Text);
                    cadastro.setGENERO(textBox10.Text);
                    cadastro.setSENHA(textBox5.Text);
                    cadastro.setCHECASENHA(textBox6.Text);
                    cadastro.setDATA_NASC(textBox7.Text);
                    cadastro.setCPF(textBox8.Text);
                    cadastro.setONDE_CONHECEU(textBox9.Text);
                    MessageBox.Show("Dados armazenados com sucesso!", "Prosseguir", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Consultar
            string consulta = "\nNome: " + cadastro.getNOME() +
                              "\nTelefone: " + cadastro.getTELEFONE() +
                              "\nCelular: " + cadastro.getCELULAR() +
                              "\nEmail: " + cadastro.getEMAIL() +
                              "\nSenha: " + cadastro.getSENHA() +
                              "\nData de nascimento: " + cadastro.getDATA_NASC() +
                              "\nCPF: " + cadastro.getCPF() +
                              "\nGênero: " + cadastro.getGENERO() +
                              "\nOnde conheceu: " + cadastro.getONDE_CONHECEU();

            MessageBox.Show(consulta, "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            var formPrincipal = new Principal();
            formPrincipal.Show();
            this.Hide();
        }
    }
}
