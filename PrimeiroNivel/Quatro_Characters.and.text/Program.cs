using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters_and_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstWord = (char)65; //so funciona com aspas simples, pois '' representa um caracter, diferente de "" que representa um texto
            Console.WriteLine(firstWord);
            Console.WriteLine((char)(firstWord + 1));

            string titulo = "Alura Cursos de tecnologia " + 2020;
            string cursosProgramacao = " - .NET" +
                " - Java" +
                " - Javascript" +
                " - SQL";

            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramacao);


            Console.ReadLine();

        }
    }
}
