using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Form
{
    class OverdraftAccount: BankAccount
    {
        public BankAccount SavingsAccount { get; set;}
        public event EventHandler InsufficientFunds;

        new public void Debit(decimal amount)
        {
            if (amount > Balance)
            {
                if (amount > SavingsAccount.Balance + Balance)
                {
                    OnOverdraft(new OverdraftEventArgs(amount, Balance));
                }
                else
                {
                    SavingsAccount.Debit(amount - Balance);
                    base.Debit(Balance);
                }
            }
            else
            {
                base.Debit(amount);
            }
        }
    }
}
