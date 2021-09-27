using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CreateVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execution project 2 - Creating Variables");

            int age = 32;
            double salary = 1200.70; // nao exibe o 0 depois do ponto
            Console.WriteLine("The developer's age is " + age);
            Console.WriteLine("The developer's salary is " + salary);

            Console.WriteLine("execution is over, type enter to exit. . .");
            Console.ReadLine();
        }
    }
}
