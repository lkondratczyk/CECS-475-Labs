using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Form
{
    class OverdraftEventArgs : EventArgs
    {
        public decimal Debit { get; set; }
        public decimal Balance { get; set; }
        public OverdraftEventArgs(decimal debit, decimal balance)
        {
            Debit = debit;
            Balance = balance;
        }
    }
}
