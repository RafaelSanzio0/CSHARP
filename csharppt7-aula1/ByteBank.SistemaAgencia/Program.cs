using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] cc = new ContaCorrente[]
            {                                           //inicializador de ARRAY
                new ContaCorrente(0466,10022),
                new ContaCorrente(0466,10022),
                new ContaCorrente(0466,10022),

            };

            for(int i = 0; i < cc.Length; i++)
            {
                ContaCorrente ccAtual = cc[i];
                Console.WriteLine("Acessando a idade " + i + " de numero " + ccAtual.Numero);

            }
            Console.ReadLine();

        }

        public void Media_Array()
        {

            int[] idades = new int[5];
            idades[0] = 20;
            idades[1] = 30;
            idades[2] = 40;
            idades[3] = 50;
            idades[4] = 60;

            //int idade4 = idades[4];
            //Console.WriteLine(idade4);
            int total_qtd = 0;
            int total_valor = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine("Acessando a idade " + i + " de indice" + idades[i]);
                total_valor += idades[i];
                total_qtd += 1;
            }
            double media = total_valor / total_qtd;
            Console.WriteLine("total das idades " + total_valor);
            Console.WriteLine("media das idades " + media);

            Console.ReadLine();

        }
    }
}
