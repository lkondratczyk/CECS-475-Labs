using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class OverdraftAccount: BankAccount
    {
        public BankAccount SavingsAccount { get; set;}
        public event EventHandler InsufficientFunds;

        new public void Debit(decimal ammount)
        {
            if (ammount > Balance)
            {
                if (ammount <= SavingsAccount.Balance)
                {
                    SavingsAccount.Debit(ammount);
                }
                else throw new 
            } else
            {
                base.Debit(ammount);
            }
        }
    }
}
