using System;

namespace TestaCodigo
{
    class Func
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> EhPositivo = (numero, numero2) =>
            {
                return numero + numero2 > 0;
            };

            bool resut = EhPositivo(7, 1);
            Console.WriteLine(resut);

        }
    }
}

//um delegate guarda a referência de memória de um método ou evento no qual definimos através da assinatura e dos parâmetros ao chamar o delegate, e o método será chamado em tempo de execução a partir da assinatura do delegate.