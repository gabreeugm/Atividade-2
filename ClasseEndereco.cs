public class ClasseEndereco
{
    //atributos da classe
    public string logradouro;
    public int numero;
    public string bairro;
    public string cep;
    public string complemento;
    public string cidade;
    public string estado;
    public string pais;
    public string ponto_ref;
    public string horario_entrega;


    //construtor padrao
    public ClasseEndereco()
    {
        this.logradouro = "";
        this.numero = 0;
        this.bairro = "";
        this.cep = "";
        this.complemento = "";
        this.cidade = "";
        this.estado = "";
        this.pais = "";
        this.ponto_ref = "";
        this.horario_entrega = "";

    }

    //contrutor e parametros
    public ClasseEndereco(string p_logradouro, int p_numero, string p_bairro, string p_cep, string p_comple, string p_cidade,
        string p_estado, string p_pais, string p_pontoref, string p_horario)
    {
        this.logradouro = p_logradouro; 
        this.numero = p_numero;
        this.bairro = p_bairro; 
        this.cep = p_cep;       
        this.complemento = p_comple;
        this.cidade = p_cidade; 
        this.estado = p_estado;
        this.pais = p_pais; 
        this.ponto_ref = p_pontoref;
        this.horario_entrega = p_horario;  

    }

    //metodos get e set
    public string getLogradouro() { return logradouro; }   
    public void setLogradouro(string p_logradouro) { this.logradouro = p_logradouro; }  

    public int getNumero() { return numero; }
    public void setNumero(int p_numero) { this.numero = p_numero; }

    public string getBairro() { return bairro; }
    public void setBairro(string p_bairro) { this.bairro = p_bairro; } 

    public string getCep() { return cidade; }
    public void setCep(string p_cep) { this.cep = p_cep; }

    public string getComple() { return complemento; }
    public void setComple(string p_comple) { this.complemento = p_comple; }

    public string getCidade() { return cidade; }
    public void setCidade(string p_cidade) { this.cidade = p_cidade; }

    public string getEstado() { return estado; }
    public void setEstado(string p_estado) { this.estado = p_estado; }

    public string getPontoref() { return ponto_ref; }
    public void setPontoref(string p_pontoref) { this.ponto_ref = p_pontoref; }

    public string getHorario() { return horario_entrega; }
    public void setHorario(string p_horario) { this.horario_entrega = p_horario; }
}
