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
    public partial class Splash : Form
    {
        Login form2 = new Login();
        public Splash()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide(); //Fecha o forms
            timer1.Enabled = false; //Desativa o timer
            form2.ShowDialog(); //Apresenta a tela de login
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }
    }
}
