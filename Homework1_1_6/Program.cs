using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int gold;
            int crystal=0;
            int transactionValue;
            int price=12;

            Console.Write("Введите, сколько у Вас золота: ");
            gold=Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько кристаллов Вы хотите купить по цене " + price + "? ");
            transactionValue = Convert.ToInt32(Console.ReadLine());
            crystal += transactionValue;
            gold -= transactionValue * price;
            Console.WriteLine("У Вас " + crystal + " кристаллов и " + gold + " золота");
        }
    }
}