namespace exercicio2;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica contratoPessoaFisica = new ContratoPessoaFisica("Contrato Pessoa Física", 1000.0, "313.546.879-00", 30);
        contratoPessoaFisica.ExibirDetalhes();
        Console.WriteLine();

        ContratoPessoaJuridica contratoPessoaJuridica = new ContratoPessoaJuridica("Contrato Pessoa Jurídica", 5000.0, "12.345.679/0009-00", "9874561230");
        contratoPessoaJuridica.ExibirDetalhes();
    }
        
    
}

