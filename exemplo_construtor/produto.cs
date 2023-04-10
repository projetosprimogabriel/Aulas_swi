namespace exemplo_construtor;
class produto
{
    public produto(){
        this.Nome = "XPTO";
        this.Preco = 1;
    }
    
    public produto(double preco){
        this.Nome = "NÃO INFORMADO";
        this.Preco = preco;
    }
    
    public produto(string nome,double desconto){
        this.Nome = nome;
        this.Preco = 10 - 10*desconto/100;
    }
   public string? Nome;
   public double Preco;

   public void MostraDados(){}

   
}