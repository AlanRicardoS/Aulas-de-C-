using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca.Entities
{
    class BusinessAccount : Account 
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount( int number, double loanLimit, string holder, double balance)
            :base(number, holder, balance)
        {

            LoanLimit = loanLimit;
        }
        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
            {
                Balance += amount;
            }
            

        }
    }

    

}
