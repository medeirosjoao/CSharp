
using ByteBank;
using ByteBank.Funcionarios;

internal class Program
{
    private static void Main(string[] args)
    {

        GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

        Funcionario carlos = new Funcionario();       
        carlos.Nome = "Carlos";
        carlos.CPF = "123.456.789.00";
        carlos.Salario = 2000;
        gerenciador.Registrar(carlos);

        Diretor roberta = new Diretor();
        roberta.Nome = "Roberta";
        roberta.CPF = "321.345.123.98";
        roberta.Salario = 5000;
        gerenciador.Registrar(roberta);

        Console.WriteLine(carlos.Nome);
        Console.WriteLine(carlos.GetBonificacao());

        Console.WriteLine(roberta.Nome);
        Console.WriteLine(roberta.GetBonificacao());
        Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

    }
}