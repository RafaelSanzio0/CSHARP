using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 16;
            bool accompanied = false;

            if (age > 18)
            {
                Console.WriteLine("João can enter");
            }
            else
            {
                if (accompanied == true)
                {
                    Console.WriteLine("João can enter, because is accompanied");
                }
                else
                {
                    Console.WriteLine("João cant't enter");
                }

            }

            Console.ReadLine();
        }
    }
}

