namespace Collections1.Stack
{
    /*
    internal class StackPlayGround
    {
        public static void Main(string[] args)
        {
            var navegador = new Navegador();
            navegador.NavegarPara("www.google.com.br"); //indice 2
            navegador.NavegarPara("www.yahoo.com.br"); // indice 1
            navegador.NavegarPara("www.facebook.com.br"); //indice 0

            navegador.Anterior();
            navegador.Anterior();

            navegador.Proximo();
            navegador.Proximo();

        }

        internal class Navegador
        {
            private string atual = null;
            private readonly Stack<string> historicoAnterior = new();
            private readonly Stack<string> historicoProximo = new();

            public Navegador()
            {
                Console.WriteLine("Página atual: " + atual);
            }

            internal void Anterior()
            {
                if (historicoAnterior.Any())
                {
                    historicoProximo.Push(atual);
                    historicoAnterior.Pop();
                    if (historicoAnterior.Count != 0)
                    {
                        atual = historicoAnterior.Peek();
                        Console.WriteLine("Voltando... Página atual: " + atual);
                    }
                }
            }

            internal void NavegarPara(string url)
            {
                atual = url;
                historicoAnterior.Push(atual);
                Console.WriteLine("Página atual: " + atual);
            }

            internal void Proximo()
            {
                if (historicoProximo.Any())
                {
                    historicoAnterior.Push(atual);
                    atual = historicoProximo.Pop();
                    Console.WriteLine("Página atual: " + atual);
                }
            }
        }
    }
    */
}
//"o último elemento que entra é o primeiro que sai", o que chamamos de LIFO,
//em inglês, "Last in, first out".
