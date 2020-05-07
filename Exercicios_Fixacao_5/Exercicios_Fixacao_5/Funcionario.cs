using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicios_Fixacao_5
{
    class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }
        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

}
