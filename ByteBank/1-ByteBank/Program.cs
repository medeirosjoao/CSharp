namespace _1_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ByteBank");
            Cliente cliente = new(nome:"João", cpf:"123.456.789-00", profissao:"Um qualquer");
            ContaCorrente cc = new(titular:cliente, agencia: 123, numero: 556677, 1037.80);
            ContaCorrente cc2 = new(titular: cliente, agencia: 123, numero: 556677, 1037.80);
            //ContaCorrente cc3 = new(titular: cliente, agencia: 123, numero: 556677, 1037.80);

            Console.WriteLine(cc.Titular.Nome);
            Console.WriteLine(cc.Titular.CPF);
            Console.WriteLine(cc.Titular.Profissao);
            Console.WriteLine(cc.Agencia);
            Console.WriteLine(cc.Numero);
            Console.WriteLine(cc.Saldo);

            Console.WriteLine(cc);
            Console.WriteLine("Total de contas: " + ContaCorrente.TotalContasCriadas);
        }
    }
}