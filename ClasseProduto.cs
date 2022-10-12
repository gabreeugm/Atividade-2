public class ClasseProduto
{
    //Atributos
    public string nome_prod;
    public string desc;
    public float buyprice;
    public float sellprice;
    public string marca;
    public int estq;
    public string forn;
    public string cores;
    public string cod;
    public string size;


    //Método Construtor 1
    public ClasseProduto()
    {
        this.nome_prod = "";
        this.desc = "";
        this.buyprice = 0;
        this.sellprice = 0;
        this.marca = "";
        this.estq = 0;
        this.forn = "";
        this.cores = "";
        this.cod = "";
        this.size = "";

    }

    //Método Construtor 2
    public ClasseProduto(string par_nome_prod, string par_desc, float par_buyprice, float par_sellprice,
                         string par_marca, int par_estq, string par_forn, string par_cores,
                         string par_cod, string par_size
)
    {
        this.nome_prod = par_nome_prod;
        this.desc = par_desc;
        this.buyprice = par_buyprice;
        this.sellprice = par_sellprice;
        this.marca = par_marca;
        this.estq = par_estq;
        this.forn = par_forn;
        this.cores = par_cores;
        this.cod = par_cod;
        this.size = par_size;
    }


    //Método Get / Set
    public string getNOME_PROD()
    {
        return this.nome_prod;
    }
    public void setNOME_PROD(string p_nome_prod)
    {
        this.nome_prod = p_nome_prod;
    }
    public string getDESC()
    {
        return this.desc;
    }
    public void setDESC(string p_desc)
    {
        this.desc = p_desc;
    }
    public float getBUYPRICE()
    {
        return this.buyprice;
    }
    public void setBUYPRICE(float p_buyprice)
    {
        this.buyprice = p_buyprice;
    }
    public float getSELLPRICE()
    {
        return this.sellprice;
    }
    public void setSELLPRICE(float p_sellprice)
    {
        this.sellprice = p_sellprice;
    }
    public string getMARCA()
    {
        return this.marca;
    }
    public void setMARCA(string p_marca)
    {
        this.marca = p_marca;
    }
    public int getESTQ()
    {
        return this.estq;
    }
    public void setESTQ(int p_estq)
    {
        this.estq = p_estq;
    }
    public string getFORN()
    {
        return this.forn;
    }
    public void setFORN(string p_forn)
    {
        this.forn = p_forn;
    }
    public string getCORES()
    {
        return this.cores;
    }
    public void setCORES(string p_cores)
    {
        this.cores = p_cores;
    }
    public string getCOD()
    {
        return this.cod;
    }
    public void setCOD(string p_cod)
    {
        this.cod = p_cod;
    }
    public string getSIZE()
    {
        return this.size;
    }
    public void setSIZE(string p_size)
    {
        this.size = p_size;
    }
}


