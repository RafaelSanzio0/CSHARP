namespace Collections1.LinkedList
{
    /*
    internal class LinkedListPlayGround
    {
        public static void Main(string[] args)
        {
            // FALANDO EM LIST
            var frutas = new List<string>
        {
            "abacate", "banana", "caqui", "damasco", "figo"
        };

            for (int i = 0; i < frutas.Count; i++)
            {
                Console.Write(frutas[i]);
            }
            //vamos imprimir essa lista =>  MEMORIA ABACATE | BANANA | CAQUI | DAMASCO | FIGO
            // quero adicionar elemento ao final é rapido mas e se eu quiser adicionar no meio ?
            // vai exigir bastante esforço computacional pois todos os elementos posterior aquele elemento
            //novo adicionado vao andar +1 para frente, e se quisermos remover vai andar -1

            // QUANDO TEMOS QUE TRABALHAR BASTANTE COM REMOÇÃO E INSERÇÃO EM LISTAS GRANDES
            // QUE ENTRA EM JOGO O LINKEDLIST
            //os elementos nao precisam estar em sequencia em memoria pois cada elemento sabe o anterior
            // e succesor dele ou seja "nó"

            var dias = new LinkedList<string>();
            var d4 = dias.AddFirst("quarta"); //cada elemento é um nó : LinkedListNode<T>

            //adicionando segunda que vem antes de quarta
            var d2 = dias.AddBefore(d4, "segunda");

            //adicionar terça depois de segunda e antes de quarta
            var d3 = dias.AddAfter(d2, "terça");

            foreach (var item in dias)
            {
                Console.Write(item + " ");
            }

            // LINKEDLIST nao da suporte a acesso de indice: dias[0] use o FIND mas se for fazer muitas bucas
            //nao é eficiente
        }
    }
    */
}
