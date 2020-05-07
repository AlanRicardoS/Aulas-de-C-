using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;

namespace Exercicio_de_Fixacao_3
{
    class Cliente
    {
        private string _nome;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }
        int conta = 0;


        public Cliente(string nome, double saldo, int conta)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
                Conta = conta;
                Saldo = saldo;
            }

        }
        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + _nome + ", Saldo: R$" + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }
        public void Deposito(double valor)
        {
            Saldo += valor+5;
        }
        public void Saque(double valor)
        {
            Saldo -= valor;
        }

    }
}
