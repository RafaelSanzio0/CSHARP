using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1.Array
{ /*
    public class ArrayPlayGround
    {
        var aulaIntro = "Introducao as colecoes";
        var aulaModelando = "Modelando a classe aula";
        var aulaSets = "Trabalhando com conjuntos";
    
        // com ARRAYS já sabemos desdo começo quais serão os itens da minha colecao
        // ele é o tipo mais basico!

        //forma 1 de declarar o array
        var aulas = new string[]
        {
            aulaIntro,
            aulaModelando,
            aulaSets
        };

        //forma 2 de declarar o array
        var aulas2 = new string[3];
        aulas2[0] = aulaIntro;
        aulas2[1] = aulaModelando;
        aulas2[2] = aulaSets;

        //aulas[0] = "mudando o valor";

        Imprimir(aulas);

        //retorna o index da primeira ocorrencia item pesquisado
        Console.WriteLine($"Exibindo o item {aulaIntro} que esta na posição {Array.IndexOf(aulas2, aulaIntro)}");

        //retorna o index da ultima ocorrencia do item pesquisado
        Console.WriteLine($"Exibindo o ultimo item {aulaSets} que esta na posição {Array.LastIndexOf(aulas2, aulaSets)}");

        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

        //inverte o array
        Array.Reverse(aulas2);
        Imprimir(aulas2);
        //volta pro estado original
        Array.Reverse(aulas2);
        Imprimir(aulas2);

        //reduzindo o tamanho do array do 3 para 2
        //Array.Resize(ref aulas, 2); //passando por referencia

        //acessando ultima posição do array
        //aulas[aulas.Length-1] = "oi";

        //ordendo array em ordem alfabetica | nao é possivel voltar para o estado inicial
        Array.Sort(aulas);

        Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

        //copiando array
        var copia = new string[2];
        Array.Copy(aulas, 1, copia, 0, 2);
        Imprimir(copia);

        //clonando array
        var clone = aulas.Clone(); // maneira legal d conversao explicita "as string[]"
        Imprimir((string[]) clone);

        //limpando array
        Array.Clear((Array) clone, 1,2);
    }

    private static void Imprimir(string[] aulas)
    {
        foreach (var item in aulas)
        {
            Console.WriteLine(item);
        }
    }
    */
}
