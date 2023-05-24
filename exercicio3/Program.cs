namespace exercicio3;
class Program
{
    static void Main(string[] args)
    {
        ContratoPessoaFisica contratoPessoaFisica = new ContratoPessoaFisica("Contrato Pessoa Física", 7000.0, 12, "321.564.879-00", 30);
        contratoPessoaFisica.ExibirDetalhes();
        Console.WriteLine("Valor da Prestação: " + contratoPessoaFisica.CalcularPrestacao());
        Console.WriteLine();

        ContratoPessoaJuridica contratoPessoaJuridica = new ContratoPessoaJuridica("Contrato Pessoa Jurídica", 3000.0, 24, "15.658.743/0009-00", "987456123");
}
}
