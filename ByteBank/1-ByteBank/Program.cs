namespace _1_ByteBank
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ByteBank");
            Cliente cliente = new Cliente(nome:"João", cpf:"123.456.789-00", profissao:"Um qualquer");
            ContaCorrente cc = new ContaCorrente(cliente: cliente, agencia: 123, numero: 556677, saldo: 123.75);

            Console.WriteLine(cc.cliente.nome);
            Console.WriteLine(cc.cliente.cpf);
            Console.WriteLine(cc.cliente.profissao);
            Console.WriteLine(cc.agencia);
            Console.WriteLine(cc.numero);
            Console.WriteLine(cc.saldo);

            Console.WriteLine(cc);
        }
    }
}