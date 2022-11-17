
using ByteBank;
using ByteBank.Funcionarios;

internal class Program
{
    private static void Main(string[] args)
    {

        GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

        Funcionario carlos = new Funcionario(2000, "123.456.789.00");       
        carlos.Nome = "Carlos";
        carlos.AumentarSalario();
        Console.WriteLine("Novo salário do Carlos é " + carlos.Salario);

        gerenciador.Registrar(carlos);
        Console.WriteLine(Funcionario.TotalDeFuncionarios);

        Diretor roberta = new Diretor("321.345.123.98");
        roberta.Nome = "Roberta";
        roberta.AumentarSalario();
        Console.WriteLine("Novo salário da Roberta é " + roberta.Salario);

        gerenciador.Registrar(roberta);
        Console.WriteLine(Funcionario.TotalDeFuncionarios);

        Console.WriteLine(carlos.Nome);
        Console.WriteLine(carlos.CPF);
        Console.WriteLine(carlos.GetBonificacao());

        Console.WriteLine(roberta.Nome);
        Console.WriteLine(roberta.CPF);
        Console.WriteLine(roberta.GetBonificacao());
        Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

    }
}