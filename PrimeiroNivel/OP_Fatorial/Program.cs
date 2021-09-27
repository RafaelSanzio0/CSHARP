using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fat = 1;

            for(int i = 1; i <= 10; i++)
            {
                fat *= i;
                Console.WriteLine("Fatorial de " + i + " eh " + fat);

            }

            Console.ReadLine();
        }
    }
}
