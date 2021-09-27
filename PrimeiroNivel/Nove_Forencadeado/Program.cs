using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nove_Forencadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int contadorLinha = 1; contadorLinha <= 10; contadorLinha++)
            {
                for(int contadorColuna = 1; contadorColuna <=10; contadorColuna++)
                {
                    if (contadorColuna < contadorLinha)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();//apenas para pular a linha
            }
            Console.ReadLine();
        }
    }
}
