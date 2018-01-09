using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //FirstLine
            Console.WriteLine("{0}|{0}", new string(' ', n + 1));

            //Body
            int emptySpaces = n - 1;
            int stars = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', emptySpaces));
                emptySpaces--;
                Console.Write(new string('*', stars));

                Console.Write(" | ");
                Console.Write(new string('*', stars));
                stars++;
                Console.WriteLine();
            }
        }
    }
}