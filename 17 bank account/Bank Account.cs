using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_bank_account
{
    class Bank_Account<T>
    {
        private T Num { get; set; }
        public string Name { get; set; }
        public int Deposit { get; set; }

        public Bank_Account(T num, string name, int deposit)
        {
            Num = num;
            Name = name;
            Deposit = deposit;
        }
        public string GetInfo()
        {
            return $"{Num} {Name} {Deposit}";
        }
    }
}
