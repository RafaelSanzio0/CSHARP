using System;
using System.Collections.Generic;

namespace ByteBank.extensoes
{
    public static class ListExtensoes2 // criando a classe como estatica pois nao pretendo criar instancias dessa classe 
    {
        // metodo generico que é um metodo static que pode ser chamado por qualquer lista
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens) //recebo a lista na qual quero adicionar os itens, recebo os itens ...
        { // passando o this no primeiro parametro do metudo é possivel chamar o metudo AdicionarVarios de qualquer classe ex: idades.AdicionarVarios() E o comportamento padrao de chamar via classe estatica tbm funciona ListExtensoes.AdicionarVarios();
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        public static void teste() //testando minha lista generica
        {
            List<int> idades = new List<int>();

            idades.Add(1);

            //idades.AdicionarVarios<int>(2, 3, 45, 6);
            idades.AdicionarVarios(2, 3, 45, 6); // mesmo metodo sem o tipo generico



            List<string> nomes = new List<string>();

            nomes.Add("joao moutinho da silva");

            //ListExtensoes2<string>.AdicionarVarios(nomes, "minisouto","tigas","roberto"); exemplo quando a classe é generica
            nomes.AdicionarVarios<string>("minisouto", "tigas", "roberto"); //exemplo quando o metodo é generico
        }
    }
}

/*
 * 
 * ! Está é a afirmação incorreta. Por mais que variáveis de object aceitem valores de int, o mesmo não vale para arrays. Não podemos usar um array de int
 * em um argumento do tipo object[].
 */