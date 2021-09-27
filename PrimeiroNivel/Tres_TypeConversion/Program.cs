using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 4");

            double salary;
            salary = 1200.50;

            float salaryFloat = 1500.50f; //eh preciso atribuir o f para o funcionamento do tipo float

            int wholeSalary;
            wholeSalary = (int)salary;

            Console.WriteLine("Whole salary " + wholeSalary);
            Console.WriteLine("Variable using float type " + salaryFloat);

            Console.ReadLine();
        }
    }
}
