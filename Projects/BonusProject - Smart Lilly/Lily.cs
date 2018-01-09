using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_101_24._04._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter Lily's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the price of the laundry machine: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter the price of one toy: ");
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int stolenMoney = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    money += i * 10 / 2;
                    stolenMoney++;
                }
                else
                {
                    toys++;
                }
            }
            decimal soldToysMoney = toys * toyPrice;
            decimal totalMoney = soldToysMoney + money -stolenMoney;
            if (totalMoney >= price)
            {
                Console.WriteLine("Yes! {0:f2}", totalMoney - price);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", price - totalMoney);
            }

        }
    }
}