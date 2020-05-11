using System;
using System.Collections.Generic;
using System.Text;

namespace Selados.Entities
{
    /* Não é Possivel Herdar a Classe devido ao selamento -- sealed 
    class SavingsAccountPlus : SavingsAccount
    {
    }
    */
    /* Não é possivel reescrever o método withdraw porque ele foi selado -- sealed
    class SavingsAccountPlus : SavingsAccount
    {
        public  override void WithDraw(double amount)
        {
            base.Withdraw(amount).
                Balance - = 2.0;
        }
    }
    */
}
