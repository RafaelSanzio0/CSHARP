using System.Collections.Generic;
using System.Collections.ObjectModel;

public class Program
{
    static void Main(string[] agrs)
    {
        var aulaIntro = "Introducao as colecoes";
        var aulaModelando = "Modelando a classe aula";
        var aulaSets = "Trabalhando com conjuntos";

        // UMA LIST TBM É CHAMADA DE ARRAY DINAMICO

        //forma 1 de declarar lista
        var aulas = new List<string>
        {
            aulaIntro,
            aulaModelando,
            aulaSets
        };

        Imprimir(aulas);


        //forma 2 de declarar lista
        var aulas2 = new List<string>();
        aulas2.Add(aulaIntro);
        aulas2.Add(aulaModelando);
        aulas2.Add(aulaSets);

        Imprimir(aulas2);

        //utilizando um metodo para percorrer a lista ao inves do for ou foreach
        aulas2.ForEach(aula =>
        {
            Console.WriteLine(aula);
        });

        //pegando o primeiro e ultimo item da lista
        aulas.First();
        aulas.Last();

        //procurar a primeira aula que contem trabalhando no nome
        aulas.First(x => x.Contains("Trabalhando"));
        aulas.Last(x => x.Contains("Trabalhando"));

        //nesse caso se ele nao encontra, diferente do exemplo acima que da excetpion ele retorna um null
        aulas.FirstOrDefault(x => x.Contains("Trabalhando"));

        //inverte lista
        aulas.Reverse();

        //remover ultimo elemento
        aulas.RemoveAt(aulas.Count - 1);

        //deixando em ordem alfabetica
        aulas.Sort();

        //copiando a lista
        var copia = aulas.GetRange(aulas.Count - 2, 2); //pegando o penultimo valor e colocano numa lista de 2 tamanhos

        //cloanando lista
        var clone = new List<string>(aulas);

        //removendo por parametros
        clone.RemoveRange(aulas.Count - 2, 2);

        // LISTA DE OBJETOS

        var aulaIntro3 = new Aula("Introdução às Coleções", 20);
        var aulaModelando3 = new Aula("Modelando a Classe Aula", 18);
        var aulaSets3 = new Aula("Trabalhando com Conjuntos", 16);

        var aulas3 = new List<Aula>
        {
            aulaIntro3,
            aulaModelando3,
            aulaSets3,
            //"Conclusão" => nao permite pois nao é do tipo aula ou derivada
        };

        //ORDERNAR LISTA EM ORDEM ALFABETA
        aulas3.Sort(); // nescessario implementar o IComparable

        //quero trocar a forma de ordenar de titulo para tempo
        aulas3.Sort((x,y) => x.Tempo.CompareTo(y.Tempo));

        // LISTA SOMENTE LEITURA
        var csharpColecoes = new Curso("C# Collections", "Marcelo Oliveira");
        csharpColecoes.Aulas.Add(new Aula("Trabalhando com Listas", 21)); // CODE SMELL AQUI, O IDEAL SERIA A CLASSE CURSO FAZER O CONTROLE DE ADICIONAR AULAS E NAO A PROPRIA AULA SER ADD
        csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21)); // criadoo metodo adiciona do curso
        Imprimir(csharpColecoes.Aulas);

        /*
         * Uma classe possui uma lista List<T>, que é um campo privado da classe, e essa lista precisa ser protegida contra gravação de
         * fora da classe. Então uma propriedade pública pode expor para os clientes da classe uma nova instância de uma lista 
         * somente-leitura (ReadOnlyCollection<T>), usando como origem de dados a lista interna que precisa ser protegida. */


        // ORDENANDO E TOTALIZANDO AULAS
        csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
        csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 19));
        // nao e possivel usar o sort nessa lista pois e de um tipo List<t>

        // entao copio aquela lista somente leitura para outra na qual posso ordenarn
        var copiaAulas = new List<Aula>(csharpColecoes.Aulas);
        copiaAulas.Sort();

    }

    class Aula : IComparable
    {
        private string titutlo;
        private int tempo;
        public int Tempo { get => tempo; set => tempo = value; }
        public string Titutlo { get => titutlo; set => titutlo = value; }

        public Aula(string titutlo, int tempo)
        {
            this.titutlo = titutlo;
            this.tempo = tempo;
        }

        public override string ToString()
        {
            return $"[titulo: {Titutlo}] - [tempo: {Tempo}]";
        }

        public int CompareTo(object obj)
        {
            var that = obj as Aula;
            return titutlo.CompareTo(that.titutlo);
        }
    }

    class Curso
    {
        public Curso(string nome, string instrutor)
        {
            aulas = new List<Aula>();
            Nome = nome;
            Instrutor = instrutor;
        }

        private IList<Aula> aulas;
        public IList<Aula> Aulas { get { return new ReadOnlyCollection<Aula>(Aulas); } }
        public string Nome { get; set; }
        public string Instrutor { get; set; }

        internal void Adiciona(Aula aula)
        {
            aulas.Add(aula);
        }
    }

    private static void Imprimir(IList<Aula> aulas)
    {
        foreach (var item in aulas)
        {
            Console.WriteLine(item);
        }
    }
}