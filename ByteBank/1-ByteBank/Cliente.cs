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
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        //public int agencia;
        //public int numero;
        //public double saldo;
        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
        }
    }
}
