namespace _1_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        private double _saldo = 100;
        public static int TotalContasCriadas { get; private set; }

        public ContaCorrente(Cliente titular, int agencia, int numero, double saldo)
        {
            Titular = titular;
            Agencia = agencia;
            Numero = numero;
            Saldo = saldo;
            TotalContasCriadas += 1;
        }

        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
                return false;
            this._saldo -= valor;
            return true;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;

            _saldo -= valor;
            contaDestino.Saldo = valor;
            return true;

        }

        public double Saldo
        {
            get { return _saldo; }
            set {
                if (value > 0)
                {
                    _saldo += value;
                }
                else
                    Console.WriteLine("Você não pode fazer isso.");
            }
        }

        
    }
}