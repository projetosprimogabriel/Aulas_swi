namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercício Conta Bancária - ETEC MCM");
        conta conta = new conta();

        conta.nomeCliente = "Gabriel Primo";
        
        conta.limite = 500;

        conta.depositar(200);

        conta.sacar(50)

        double saldo = conta.ConsutaSaldo();

        Console.WriteLine("seu saldo é: "+saldo);

    }
}
