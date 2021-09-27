using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oito_AlongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            double valueInvested = 1000.0, monthlyInvestment = 0.0036;
            
            for (int year = 1; year <= 5; year++)
            {
                Console.WriteLine(year + "ano");

                for (int month = 1; month <= 12; month++)
                {
                    
                    valueInvested = valueInvested + (valueInvested * monthlyInvestment);
                    Console.WriteLine("Apos " + month + " mes voce tera " + valueInvested);

                }

                monthlyInvestment += 0.0010;

            }
            Console.WriteLine("total do investimento "+valueInvested);

            Console.ReadLine();
        }
    }
}
