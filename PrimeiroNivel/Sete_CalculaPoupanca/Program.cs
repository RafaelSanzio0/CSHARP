using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sete_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programa 7- calcule o investimento de uma conta durante o ano todo, de mes em mes");

            double valueInvested = 1000.0;
            int month = 1;

            while(month <= 12)
            {
                valueInvested = valueInvested + (valueInvested * 0.0036);
                Console.WriteLine("Apos "+month+" mes voce tera "+ valueInvested);
                month++;

            }

            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=+=");

            month = 0;
            valueInvested = 1000.0 ;
           
           for (month = 1; month <= 12; month++)
           {
               valueInvested = valueInvested + (valueInvested * 0.0036);
               Console.WriteLine("Apos " + month + " mes voce tera " + valueInvested);

           }
          
            Console.ReadLine();

        }
    }
}
