using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta c = new Conta(0466,10001);

            c.titular = "Gabriel";
            c.numeroAgencia = 863;
            c.numeroConta = 863452;
            c.saldo = 100;
            c.saca(10);

            Cliente cc = new Cliente();
            cc.sexo = "masculino";

            
           





            //Console.WriteLine("Cliente da conta "+ c +" eh"+ cc);
            Console.ReadLine();

  
        }
    }
}
