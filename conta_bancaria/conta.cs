namespace conta_bancaria;

class conta

{
    public string? nomeCliente {get;set;}

    public int numeroConta {get; set;}

    public double saldo {get; set;}

    public double limite {get;set;}


    public void depositar(double valor){
        this.saldo +=valor;

    }

    public double ConsutaSaldo(){
        return this.saldo + this.limite;
    }  
    public void sacar (double valor){
        this.saldo -= valor;


    }

    
 }
