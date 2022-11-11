using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        //public int agencia;
        //public int numero;
        //public double saldo;
        public Cliente(string nome, string cpf, string profissao)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.profissao= profissao;
        }
    }
}
