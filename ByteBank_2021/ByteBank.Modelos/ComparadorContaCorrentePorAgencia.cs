using System;
using System.Collections.Generic;

namespace ByteBank.Modelos
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public ComparadorContaCorrentePorAgencia()
        {
        }

        public int Compare(ContaCorrente x, ContaCorrente y) // segue a mesma logica do comparable só que nao comparando obj e instancia e sim dois obj
        {

            if (y == x)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            if (x.Agencia < y.Agencia)
            {
                return -1; // x fica na frente do y
            }

            if (x.Agencia > y.Agencia)
            {
                return 1; // y fica na frente de x
            }

            return 0; // sao equivalentes

            // retornar negativo quando a x precede o y
            // retornar 0 quando o x é equivalente ao y
            // retornar positivo quando o y precede a x 
        }
    }
}
