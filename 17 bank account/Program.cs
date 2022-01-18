using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числовой номер счета: ");
            int numInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите сумму на счете: ");
            int deposit = Convert.ToInt32(Console.Read());
            Bank_Account<int> bank_Account1 = new Bank_Account<int>(numInt, name, deposit);
            Console.WriteLine(bank_Account1.GetInfo());
            //Console.ReadKey();
            Console.Write/*Line*/("Введите строковый номер счета: ");
            string numString = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.Write("Введите сумму на счете: ");
            deposit = Convert.ToInt32(Console.Read());
            Bank_Account<string> bank_Account2 = new Bank_Account<string>(numString, name, deposit );
            Console.Write(bank_Account2.GetInfo());
            Console.ReadKey();
        }
    }
}
