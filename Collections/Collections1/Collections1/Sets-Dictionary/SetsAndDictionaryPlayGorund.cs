using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections1.Sets_Dictionary
{
    /*
    internal class SetsAndDictionaryPlayGorund
    {
        public static void Main(string[] args)
        {
            // SET = CONJUNTOS

            //DUAS PROPRIEDADES DO SET
            //1. NAO PERMITE DUPLICIDADE
            //2. OS ELEMENTOS NAO SAO MANTIDOS EM ORDEM ESPECIFICA

            //A VANTAGENS
            //1. A PERFORMANCE DO HASHSET É MAIS RAPIDO DO QUE LIST POIS INDEPENDENTE DA QTD DE ELEMENTOS O TEMPO D BUSCA É O MESMO
            // JA NA LISTA ELE AUMENTA CONFORME A QTD DE ELEMENTOS MAS O CUSTO DE MEMORIA É MENOR TBM

            // add
            var alunos = new HashSet<string>
        {
            "Rafael",
            "Julio",
            "Sanzio"
        };

            //print
            Console.WriteLine(string.Join(",", alunos));

            // tentando adicionar elemento repetido
            alunos.Add("Rafael");
            Console.WriteLine(string.Join(",", alunos)); // nao da erro mas é como se fosse ignorado



            //vamos declarar o curso
            Curso csharpColecoes = new("C# Colecoes", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 24));

            //um aluno também tem matrícula!
            //vamos criar a classe Aluno com Nome e NumeroMatricula
            Aluno a1 = new("Vanessa Tonini", 34672);
            Aluno a2 = new("Ana Losnak", 5617);

            Aluno a3 = new("Rafael Nercessian", 17645);

            //Precisamos matricular os alunos no curso, criando um método
            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            //imprimindo os alunos matriculados
            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }

            //Criar um método EstaMatriculado
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            //limpando o console
            Console.Clear();

            //já temos método para saber se o aluno está matriculado.
            //mas agora precisamos buscar aluno por número de matrícula

            //pergunta: "Quem é o aluno com matrícula 5617?"
            Console.WriteLine("Quem é o aluno com matrícula 5617?");
            //implementando Curso.BuscaMatriculado
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(56117);

            //imprimindo o aluno5617 encontrado
            Console.WriteLine("aluno5617: " + aluno5617);

            //Será que esta busca pode ser melhorada?
            // O.NET Framework felizmente possui um tipo de coleção específico,
            //     o dicionário, que permite associar uma chave(no caso, a matrícula)
            //     a um valor(o nome do aluno).
        }

        class Aluno
        {
            public string Nome { get; set; }
            public int NumeroMatricula { get; set; }

            public Aluno(string nome, int numeroMatricula)
            {
                NumeroMatricula = numeroMatricula;
                Nome = nome;
            }

            public override string ToString()
            {
                return $"[Nome: {Nome}, Matrícula: {NumeroMatricula}]";
            }

            public override bool Equals(object obj) // equals por padrao compara a instancia assim como o ==
            {
                var outro = obj as Aluno;

                if (obj == null) { return false; }
                return Nome.Equals(outro.Nome);
            }

            public override int GetHashCode() // o mesmo hascode pode conter mais de um elemento ( ao implementar o metodo equals deve sempre implementar esse tbm)
            {
                return this.Nome.GetHashCode();
            }

            /*
             * No início da classe Aluno, veremos como observação, um alerta que indica que esta classe sobrescreve o Equals() mas não o GetHashCode. O que isto significa?

            Trata-se de um código de dispersão, ou espalhamento. A imagem abaixo representa o nosso conjunto de alunos,
            que são convertidos internamente no HashSet para códigos. Estes cairão em uma tabela de dispersão, também conhecida por HashTable, responsável por informar as "caixinhas" em que estes conjuntos de alunos cairão.

            Quer dizer que quanto maior a dispersão, ou mais espalhado forem as caixinhas, maior será a eficiência no algoritmo de busca para posterior comparação ou verificação de um elemento em um objeto.
            Como podemos ver na imagem, todos os alunos caíram em caixas diferentes, com exceção do Rafael Rollo e do Rafael Nercessian, que caíram em 152 (o HashCode gerado, o tal do código de dispersão), em que ocorreu uma colisão de códigos.

            Uma colisão indica que dois ou mais elementos estão caindo no mesmo grupo. Nisso, verifica-se se o elemento está realmente contido naquela caixa e, paralelamente, todos os seus elementos são varridos.
            Ou seja, para verificar se o Rafael Nercessian está contido em uma caixa específica, por exemplo, passamos primeiro pelo Rafael Rollo. É como se uma "segunda etapa" tivesse acontecido.

            Poderíamos ter muitos elementos em uma única caixa, deixando nosso código menos eficiente. Então, via de regra, ao implementarmos o método Equals(), fazemos o mesmo com o GetHashCode para que a
            dispersão aconteça corretamente. Reforçando também que a rapidez de busca depente do código de dispersão.

            Para implementarmos este código de dispersão (GetHashCode), utilizaremos o override para sobrescrita. Como boa prática, seguiremos o mesmo conceito do Equals(), que compara nome com nome. Em Alunos.cs:

                                                    BONUS

            Em muitas aplicações além da busca rápida, também precisamos manter a ordenação dos elementos de um conjunto. Nesse tipo de aplicação, podemos utilizar uma nova classe do C# chamada SortedSet.

            O SortedSet funciona de forma similar ao HashSet, utilizamos o Add para adicionar um elemento, o Remove para remover itens, o Count para perguntar quantos
            elementos estão armazenados e Contains para verificar se um determinado elemento está no conjunto. A diferença é que no HashSet os elementos são espalhados em categorias e por isso não sabemos qual é a ordem da iteração, já o SortedSet guarda os elementos na ordem crescente.
            https://www.alura.com.br/apostila-csharp-orientacao-objetos/lidando-com-conjuntos#conjuntos-ordenados-com-o-sortedset
            


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
            public IList<Aula> Aulas { get { return new ReadOnlyCollection<Aula>(Aulas.ToList()); } }
            public string Nome { get; set; }
            public string Instrutor { get; set; }

            private IDictionary<int, Aluno> dicionarioAlunos = new Dictionary<int, Aluno>();
            //diferença entre add e indexador em diciotinary
            // add só adiciona ja o indexador adiciona ou substitui itens


            public int TempoTotal
            {
                get
                {
                    //int total = 0;
                    //foreach (var aula in aulas)
                    //{
                    //  total += aula.Tempo;
                    //}
                    //return total;

                    //LINQ = Language Integrated Query
                    //Consulta Integrada à Linguagem

                    return aulas.Sum(aula => aula.Tempo); // linq e bastante util pra fazer query em cima d colecoes
                }
            }

            //alunos deve ser um ISet. Alunos deve retornar ReadOnlyCollection
            private ISet<Aluno> alunos = new HashSet<Aluno>();
            public IList<Aluno> Alunos
            {
                get
                {
                    return new ReadOnlyCollection<Aluno>(alunos.ToList());
                }
            }

            internal void Matricula(Aluno aluno)
            {
                alunos.Add(aluno);
                dicionarioAlunos.Add(aluno.NumeroMatricula, aluno);
            }

            internal void Adiciona(Aula aula)
            {
                aulas.Add(aula);
            }


            public bool EstaMatriculado(Aluno aluno)
            {
                return alunos.Contains(aluno);
            }

            internal Aluno BuscaMatriculado(int numeroMatricula)
            {
                /*
                foreach (var aluno in alunos)
                {
                    if (aluno.NumeroMatricula == numeroMatricula)
                    {
                        return aluno;
                    }
                }
                
                //BUSCA OTIMIZADA AGR POR DICTIONARY
                return dicionarioAlunos.ContainsKey(numeroMatricula) ? dicionarioAlunos[numeroMatricula] : null;

                // outra forma d busca
                Aluno aluno = null;
                dicionarioAlunos.TryGetValue(numeroMatricula, out aluno);
                return aluno;

            }


        }
    }
*/
}
