﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class BankAccount
    {
                
        // The account balance.
        public decimal Balance { get; set; }

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

        }
    }
}
