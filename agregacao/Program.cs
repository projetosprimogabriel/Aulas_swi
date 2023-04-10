namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("trabalhando com agregação");

        cartaodecredito cdc = new cartaodecredito();
        cliente cli = new cliente();

        cli.Nome = "Gabriel Primo";

        cdc.Numero = "123456789";
        cdc.DataValidade = "07/2025";

        cdc.cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome);
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
        Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);




    }
}
