using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_Fixacao_9.Entites
{
    class Company : TaxPayer
    {
        public int NumberOfEmpoyee { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome, int numberOfEmpoyee): base(name,anualIncome)
        {
            NumberOfEmpoyee = numberOfEmpoyee;
        }

        public override double Tax()
        {
            if (NumberOfEmpoyee < 10)
            {
                return AnualIncome * 0.10;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }

    }
}
