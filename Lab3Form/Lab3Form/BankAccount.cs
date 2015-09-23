using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Form
{
    class BankAccount
    {

        // The account balance.
        public decimal Balance { get; set; }

        // the event handler
        public event EventHandler<OverdraftEventArgs> Overdraft;

        // Add money to the account.
        public void Credit(decimal amount)
        {
            Balance += amount;
        }

        // Remove money from the account.
        public void Debit(decimal amount)
        {
            // See if there is this much money in the account.
            if (Balance >= amount)
            {
                // Remove the money.
                Balance -= amount;
            }
            else
            {
                OnOverdraft(new OverdraftEventArgs(amount, Balance));
            }
        }

        //define event listener method
        protected virtual void OnOverdraft(OverdraftEventArgs e)
        {
            EventHandler<OverdraftEventArgs> handler = Overdraft;
            if(handler != null)
            {
                handler(this, e);
            }
        }
    }
}
