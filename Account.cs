using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public string Pin { get; set; }
        public decimal Balance { get; set; }

        public Account(string pin, decimal balance)
        {
            Pin = pin;
            Balance = balance;
        }
    }
}
