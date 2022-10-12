using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    public class ClasseCadastro
    {

        //atributos
        public string nome;
        public string telefone;
        public string celular;
        public string email;
        public string senha;
        public string checa_senha;
        public string data_nasc;
        public string cpf;
        public string genero;
        public string onde_conheceu;


        //método - Construtor 1
        public ClasseCadastro() //serve como por exemplo no console quando declara o valor das variáveis
        {
            this.nome = "";
            this.telefone = "";
            this.celular = "";
            this.email = "";
            this.senha = "";
            this.checa_senha = "";
            this.data_nasc = "";
            this.cpf = "";
            this.genero = "";
            this.onde_conheceu = "";

        }

        //método - Construtor 2
        public ClasseCadastro(string par_nome, string par_telefone, string par_celular, string par_email,
                        string par_senha, string par_checa_senha, string par_data_nasc, string par_cpf,
                        string par_genero, string par_onde_conheceu
)
        {
            this.nome = par_nome;
            this.telefone = par_telefone;
            this.celular = par_celular;
            this.email = par_email;
            this.senha = par_senha;
            this.checa_senha = par_checa_senha;
            this.data_nasc = par_data_nasc;
            this.cpf = par_cpf;
            this.genero = par_genero;
            this.onde_conheceu = par_onde_conheceu;
        }


        //método - Get e Set
        public string getNOME()
        {
            return this.nome;
        }
        public void setNOME(string p_nome)
        {
            this.nome = p_nome;
        }
        public string getEMAIL()
        {
            return this.email;
        }
        public void setEMAIL(string p_email)
        {
            this.email = p_email;
        }
        public string getGENERO()
        {
            return this.genero;
        }
        public void setGENERO(string p_genero)
        {
            this.genero = p_genero;
        }
        public string getSENHA()
        {
            return this.senha;
        }
        public void setSENHA(string p_senha)
        {
            this.senha = p_senha;
        }
        public string getCHECASENHA()
        {
            return this.checa_senha;
        }
        public void setCHECASENHA(string p_checa_senha)
        {
            this.checa_senha = p_checa_senha;
        }
        public string getTELEFONE()
        {
            return this.telefone;
        }
        public void setTELEFONE(string p_telefone)
        {
            this.telefone = p_telefone;
        }
        public string getCELULAR()
        {
            return this.celular;
        }
        public void setCELULAR(string p_celular)
        {
            this.celular = p_celular;
        }
        public string getCPF()
        {
            return this.cpf;
        }
        public void setCPF(string p_cpf)
        {
            this.cpf = p_cpf;
        }
        public string getDATA_NASC()
        {
            return this.data_nasc;
        }
        public void setDATA_NASC(string p_data_nasc)
        {
            this.data_nasc = p_data_nasc;
        }
        public string getONDE_CONHECEU()
        {
            return this.onde_conheceu;
        }
        public void setONDE_CONHECEU(string p_onde_conheceu)
        {
            this.onde_conheceu = p_onde_conheceu;
        }
    }
}
