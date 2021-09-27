using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using ByteBank.Modelos;
using Humanizer;
using System.Text.RegularExpressions;
using ByteBank.SistemaAgencia;
using System.Collections.Generic;
using ByteBank.extensoes;
using System.Linq;
using System.IO;
using System.Text;

namespace ByteBank
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            // -=-=-=-=-=-=-=-=-= CURSO PARTE 2 - ORIENTACAO A OBJETOS -=-=-=-=-=-=-=-=-
            //ContaCorrente contaCorrente = new ContaCorrente(0655, 12345); // criando uma instancia de objeto
            //contaCorrente.Saldo = -10; // debaixo dos panos o compilador chama o setSaldo()

            //contaCorrente.Titular = new Cliente();
            //contaCorrente.Titular.Nome = "Rafael Sanzio"; // aqui temos um exemplo de composicao em uso
            //contaCorrente.Titular.Cpf = CPF.GerarCpf();
            //contaCorrente.Titular.Profissao = "QA Engineer";



            //ContaCorrente contaCorrente2 = new ContaCorrente(0500, 54321);
            //contaCorrente2.Numero = 87654321;
            //contaCorrente2.Agencia = 655;

            //contaCorrente2.Titular = new Cliente();
            //contaCorrente2.Titular.Nome = "Janiele da Silva";
            //contaCorrente2.Titular.Cpf = CPF.GerarCpf();
            //contaCorrente2.Titular.Profissao = "Devops Engineer";
            ////Console.WriteLine("Saldo da conta destino " + contaCorrente2.Saldo); //por debaixo dos panos o compilador chama getSaldo()

            //Console.WriteLine("Total de contas criadas " + ContaCorrente.TotalDeContasCriadas);




            // -=-=-=-=-=-=-=-=-= CURSO PARTE 3 - INTERFACE E HERANCAS -=-=-=-=-=-=-=-=-
            //GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();
            //SistemaInterno sistemaInterno = new SistemaInterno();

            //Funcionario carlos = new Auxiliar(CPF.GerarCpf());
            //carlos.Nome = "Carlos";
            //gerenciadorBonificacao.registrar(carlos);
            //carlos.AumentarSalario();
            //Console.WriteLine("Novo salario de " + carlos.Nome + " é " + carlos.Salario);
            //Console.WriteLine("Bonificacao de " + carlos.Nome + " é " + carlos.GetBonificacao());

            //Diretor roberta = new Diretor(CPF.GerarCpf());
            //roberta.Nome = "Roberta";
            //gerenciadorBonificacao.registrar(roberta);
            //roberta.Senha = "123";

            //ParceiroComercial parceiroComercial = new ParceiroComercial();
            //parceiroComercial.Senha = "abcd"; // supondo que peguei essa senha do banco


            //Designer melinda = new Designer(CPF.GerarCpf());
            //melinda.Nome = "Melinda";



            //sistemaInterno.Logar(roberta,"123");
            //sistemaInterno.Logar(parceiroComercial, "123"); // ai vou logar no sistema com senha incorreta


            // -=-=-=-=-=-=-=-=-= CURSO PARTE 4 - EXCECOES -=-=-=-=-=-=-=-=-

            //try
            //{
            //    ContaCorrente contaCorrente = new ContaCorrente(34, 100);

            //    contaCorrente.Depositar(50);
            //    contaCorrente.Sacar(40);
            //    Console.WriteLine("Saldo atual {0}", contaCorrente.Saldo);


            //    ContaCorrente contaCorrente2 = new ContaCorrente(35, 101);
            //    contaCorrente2.Transferir(contaCorrente,1000);

            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //}
            //catch (ArgumentException e)
            //{
            //    Console.WriteLine("Argumento com problema " + e.ParamName);
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);

            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);

            //}
            //catch (OperacaoFinanceiraException e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("********Informacao da INNER EXCEPTION********");
            //    Console.WriteLine(e.InnerException.StackTrace);
            //    Console.WriteLine(e.InnerException.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.StackTrace);
            //    Console.WriteLine(e.Message);
            //}

            //  MainClass.Metodo();


            // -=-=-=-=-=-=-=-=-= CURSO PARTE 5 BIBLIOTECAS DLL, NUGET E DOCUMENTACAO -=-=-=-=-=-=-=-=-

            //ContaCorrente contaCorrente = new ContaCorrente(846,1234); // CONTA CORRENTE CRIADA A PARTIR DE UMA LIB IMPORTADA NO PROJETO
            //FuncionarioAutenticavel carlos = null;
            //carlos.Senha = "123";
            //carlos.Autenticar("abc"); // correto uso da classe internal permitida pois esta dentro do escopo .modelos
            //Console.WriteLine(contaCorrente.Agencia); // teste - executando pelo BIN o arquivo exe


            //DateTime dataFimPagamento = new DateTime(2021,8,18);
            //DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = dataFimPagamento - dataCorrente; // timeSpan serve para calcular diferenca entre datas

            //Console.WriteLine(dataFimPagamento);
            //Console.WriteLine(dataCorrente);


            //Console.WriteLine(GetIntervaloDeTempoLegivel(diferenca));

            // TimeSpanHumanizeExtensions.Humanize()


            // -=-=-=-=-=-=-=-=-= CURSO PARTE 6 STRING, REGEX E CLASSE OBJECT -=-=-=-=-=-=-=-=-

            //string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";

            ////Console.WriteLine(url);
            ////Console.WriteLine(url.Substring(7)); // tras como argumentos
            ////Console.WriteLine(url.IndexOf("?")); // tras o indice do char


            ////2.) Contudo, estamos usando a sobrecarga de Substring que devolve toda a string a partir de um índice. Nosso código não funciona para situações como abaixo:
            //string url2 = "www.bytebank.com/cambio?origem=real&destino=dolar";
            //ExtratorValorDeArgumentoURL extrator = new ExtratorValorDeArgumentoURL(url2);
            //extrator.GetValor("origem"); // real&destino=dolar


            ///*
            // * string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // * string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // * string padrao = "[0-9]{4}[-][0-9]{4}";
            // * string padrao = "[0-9]{4}-[0-9]{4}";
            // * string padrao = "[0-9]{4,5}-[0-9]{4}";
            // * string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            // */
            //string padrao = "[0-9]{4,5}-?[0-9]{4}";//define um padrao por indice usando quantificador {}
            //   // pego um numero que pode ser de 0 ate 9 quatro vezes que pode ter 4 ou 5 digitos e pode ou nao ter um hifem

            //string texto = "Meu número é: 2342-3453";

            //Match match = Regex.Match(texto, padrao); 
            //Console.WriteLine(match.Value); //devolve o valor do padrao


            //Cliente carlos_1 = new Cliente();
            //carlos_1.Nome = "Carlos";
            //carlos_1.CPF = "458.623.120-03";
            //carlos_1.Profissao = "Designer";

            //Cliente carlos_2 = new Cliente();
            //carlos_2.Nome = "Carlos";
            //carlos_2.CPF = "458.623.120-03";
            //carlos_2.Profissao = "Designer";

            //if (carlos_1.Equals(carlos_2))
            //{
            //    Console.WriteLine("São iguais!");
            //}

            // -=-=-=-=-=-=-=-=-= CURSO PARTE 7 ARRAY E TIPOS GENERICOS e CURSO 08 List, lambda e Linq -=-=-=-=-=-=-=-=-

            // List<int> idades = new List<int>{ 2, 4, 6, 8, 10 }; //array de inteiro com 5 posicoes

            // ao inves de declarar assim
            //ContaCorrente conta = new ContaCorrente(322, 12345);
            //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            //List<GerenciadorBonificacao> gerenciadors = new List<GerenciadorBonificacao>();

            //user o var
            //var conta = new ContaCorrente(322, 12345);
            //var gerenciador = new GerenciadorBonificacao();
            //var gerenciadors = new List<GerenciadorBonificacao>();
            ////var resultadoMetodo = metodoQueRetornaInteiro(1, 2, 3, 4);


            //var idades = new List<int>();
            //int acumulador = 0;


            //idades.Add(1);
            //idades.Add(2);
            //idades.Add(4);
            //idades.Add(6);
            //idades.Add(8);
            //idades.AddRange(new int[]{20, 30, 40, 50});
            //idades.AdicionarVarios(66, 77, 55); // metudo de extensao

            //ListExtensoes2.AdicionarVarios(idades, 1, 2, 3, 4, 5, 6, 7, 8);

            //idades.Remove(1);


            //for (int i = 0; i < idades.Count; i++)
            //{
            //    Console.WriteLine(idades[i]);
            //    int idade = idades[i];
            //    acumulador += idade;
            //}
            //int media = acumulador / idades.Count;
            //Console.WriteLine(media);


            //ListaDeContaCorrente listaDeContaCorrente = new ListaDeContaCorrente();
            //{
            //    listaDeContaCorrente.Adicionar(new ContaCorrente(874, 5679786));
            //    listaDeContaCorrente.Adicionar(new ContaCorrente(812, 0012386));
            //    listaDeContaCorrente.Adicionar(new ContaCorrente(834, 9975686));
            //    listaDeContaCorrente.Adicionar(new ContaCorrente(822, 5679786));
            //    listaDeContaCorrente.Adicionar(new ContaCorrente(811, 0012386));
            //    listaDeContaCorrente.Adicionar(new ContaCorrente(899, 9975686));


            //}

            //listaDeContaCorrente.TestaArgumentoOpcional(numero: 10); // alterando apenas um argumento opcional

            //Console.WriteLine(listaDeContaCorrente.GetConta(3));

            //TESTANDO A LISTA GENERICA - com isso consigo controlar em tempo de execucao o tipo de dado que é adicionado ao meu array

            //Lista<int> listaGenerica = new Lista<int>();

            //listaGenerica.Adicionar(1);
            //listaGenerica.Adicionar("1");



            //TESTANDO ORDENACAO

            // var nomes = new List<string>()
            //{
            //    "wesley",
            //    "ana",
            //    "bolos",
            //    "balbinu",
            //    "zaca",
            //    "kiny",

            //};

            // nomes.Sort(); // ordeno

            // foreach (var nome in nomes) // imprimo elemento por elemento na tela
            // {
            //     Console.WriteLine(nome);
            // }

            // Console.WriteLine("****TESTANDO ICOMPARABLE****");


            // var contas = new List<ContaCorrente>()
            // {
            //   new ContaCorrente(122, 22345),
            //   new ContaCorrente(222, 42345),
            //   null,
            //   new ContaCorrente(022, 02345),
            //   new ContaCorrente(912, 62345),
            //   null,
            //   new ContaCorrente(543, 92345),
            // };

            //contas.Sort(); // ele cai no comparable que foi implementado na classe ** exemplo de uso chamando a classe comparable

            //contas.Sort(new ComparadorContaCorrentePorAgencia()); // chamando da classe que implementa o IComparer

            //   **************
            //var listaSemNulos = new List<ContaCorrente>(); // JEITO ANTIGO DE ORDENAR

            //foreach (var conta1 in contas)
            //{
            //    if(conta1 != null)
            //    {
            //        listaSemNulos.Add(conta1);
            //    }
            //}


            // JEITO NOVO DE ORDERNAR USANDO OPERADORES LINQ
            //    var contasOrdenadas = contas
            //        .Where(conta2 => conta2 != null)
            //        .OrderBy(conta2 => conta2.Numero);  // outra forma de ordenar sem ser pelo sort --> comparable/comparer


            //    foreach (var conta2 in contasOrdenadas)
            //    {
            //        Console.WriteLine($"Conta número {conta2.Numero}, ag. {conta2.Agencia}");
            //    }


            //    Console.ReadLine();
            //}




            //static string GetIntervaloDeTempoLegivel(TimeSpan timespan)
            //{
            //    return (timespan.Days+1) + " dias";
            //}




            // private static void Metodo()
            //{
            //    TestaDivisao(10, 0);
            //}

            //private static void TestaDivisao(int numero, int divisor)
            //{

            //    int resultado = Dividir(numero, divisor); //caso de erro aqui ele vai direto pro catch
            //    Console.WriteLine("Resultado da divisao é " + resultado);

            //    Console.WriteLine("Nao é possivel dividir por 0");
            //}

            //private static int Dividir(int numero, int divisor)
            //{
            //    try
            //    {
            //        return numero / divisor;

            //    }
            //    catch (DivideByZeroException e)
            //    {
            //        Console.WriteLine(e.Message);
            //        throw; // sem o throw o metudo nao retona nada e como precisa retornar ele da erro | joga exception pra cima pra alguem tratar
            //    }
            //}


            // -=-=-=-=-=-=-=-=-= CURSO PARTE 9 STEAM DE DADOS/ARQUIVOS-=-=-=-=-=-=-=-=-


            var enderecoDoArquivo = "contas.txt"; // file no path default bin/debug


            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open)) // digo que quero abrir esse file
            using (var leitor = new StreamReader(fluxoDoArquivo))
            {
                while (!leitor.EndOfStream) //equanto a gente nao chegou no fim do nosso arquivo, eu quero ler a proxima linha de mostar na tela
                {
                    var linha = leitor.ReadLine();
                    var conversao = ConverterStringToCorrente(linha);
                    var msg = $"Agencia {conversao.Agencia} Conta {conversao.Numero} Saldo {conversao.Saldo} Titular {conversao.Titular}";
                    Console.WriteLine(msg);
                }
            } // DICA: SE A CLASSE IMPLEMENTA A IDISPOSABLE VC DEVE USAR O USING

            CriarArquivoComWritter();
            Console.WriteLine("Arquivo escrito");
               
                  
           
            Console.ReadLine();
        }

        static void CriarArquivoComWritter()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo)) //se eu preciso que meu arquivo esteja imediatamente no HD eu uso o metodo flush ao inves do write
            {
                escritor.Write("1234,34524,454.32,Pedro");
            }
        }

        static ContaCorrente ConverterStringToCorrente(string objeto)
        {
            var campos = objeto.Split(' ');
            var agencia = campos[0];
            var conta = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nometitular = campos[3];

            var agenciaComoInt = int.Parse(agencia);
            var contaComoInt = int.Parse(conta);
            var saldoComoDouble = double.Parse(saldo);
            var titular = new Cliente();
            titular.Nome = nometitular;


            var resultado = new ContaCorrente(agenciaComoInt, contaComoInt);
            resultado.Depositar(saldoComoDouble);

            return resultado;
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);
            Console.Write(texto); // apos converter os bytes pa texto imprimo na tela


            //foreach (var meuByte in buffer) // aqui to escrevendo os byte do arquivo
            //{
            //    Console.Write(meuByte);
            //    Console.Write(" ");
            //}
        }

        
    }
}



//                                         ANOTACOES CURSO PARTE 4 

/* comportamento basicamente é capturar uma exceção e relançar para o próximo métudo na pilha de chamadas.
 * 
 * Nesta aula, enfrentamos alguns desafios para lidar com a leitura de um arquivo e seu fechamento. Escrevemos bastante código para nos certificar de que 
 * o métudo Fechar será sempre invocado. Nestas situações, podemos usar o bloco using.

Sobre o bloco using, marque as alternativas corretas:

Para usarmos o bloco using com o código using (RecursoDoSistema recurso = new RecursoDoSistema()) { … }, é necessário que o RecursoDoSistema implemente a interface IDisposable.

O using é um açúcar sintático para o código:

RecursoDoSistema recurso = null;
try
{
    recurso = new RecursoDoSistema();
    recurso.Usar();
}
finally
{
    if(recurso != null)
    {
        recurso.Dispose();
    }
}

                                          ANOTACOES CURSO PARTE 5

Douglas começou a rascunhar a criação de uma solução com vários projetos para o sistema console dos caixas do supermercado Bom e chegou no diagrama abaixo:

[Solução] SupermercadoBom
    [Projeto-1] SupermercadoBom.Modelos
    [Projeto-2] SupermercadoBom.Utilidades
    [Projeto-3] SupermercadoBom.SistemaCaixa

Contudo, ele está com dúvidas sobre o tipo de cada projeto da solução. Você pode ajudá-lo?

Projeto-1 e Projeto-2 devem ser do tipo biblioteca de Classes e o Projeto-3 um projeto de aplicação do console.


Correta! Desta forma, o resultado da compilação de todos estes projetos será SupermercadoBom.Modelos.dll, SupermercadoBom.Utilidades.dll e SupermercadoBom.SistemaCaixa.exe!



REFERENCIANDO DLL PARA OUTROS PROJETOS

EM UMA OUTRA SOLUTION QUE NAO POSSUE O CODIGO FONTE DA .MODELOS NÓS PODEMOS PEGAR O DLL QUE É GERADO SEMPRE APOS UMA EXECUCAO E JOGAR NUMA PASTA LIB > arquivo.dll
NESSA OUTRA SOLUTION PODEMOS BUSCAR O ARQUIVO.DLL E UTILIZAR TODOS OS SEUS METODOS.

quando clicamos EM IR A DEFINICAO DE UM TIPO STRING POR EXEMPLO ELE NOS LEVA A UMA PAGINA QUE CONTEM SOMENTE A DEFINICAO DOS ATRIBUTOS/METODOS E NAO EM SI O CODIGO FONTE, TEREMOS
ESSE MESMO COMPORTAMENTO SE NO OUTRA SOLUTION CLICAR-MOS EM ALGUMA CLASSE DO .MODELOS DLL COMO POR EXEMPLO A CONTA CORRENTE



                                          ANOTACOES CURSO PARTE 7

 - problema dos arrays é que o valor que é definido na sua inicializacao é imutavel ou seja eu nao consigo adicionar mais itens caso seja nescessario depois
- com uma lista eu nao me preocupo em qual posicao inserir o valor xpto ou se ele tem o tamanho para isso



                                          ANOTACOES CURSO PARTE 8



Métodos de extensão não adicionam comportamento para uma classe. Eles são métodos utilitários sem relação.

A classe Aula não implementa a interface IComparable e, por consequência, não implementa o método CompareTo.
Isso mesmo! A interface IComparable exige uma implementação do método CompareTo, que precisa ser chamado pelo
algoritmo interno do método Sort() da classe List<T>.


                                          ANOTACOES CURSO PARTE 9


Pra gente parar de se preocupr com bytes, buffer utilizaremos a classe StreamReader

*********JEITO ANTIGO********* COM BYTES

using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open)) // digo que quero abrir esse file
            {
                var buffer = new byte[1024]; // 1kb => me preocupo com o size do file
                var numeroDoBytesLidos = -1;

                while (numeroDoBytesLidos != 0) // condicao para ler todo file 
                {
                    numeroDoBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); // passo buffer, inicio do 0 e vou ate o tamanho do buffer
                    EscreverBuffer(buffer);
                }
            }

            Console.ReadLine();
        }

        static void EscreverBuffer(byte[] buffer)
        {
            var utf8 = Encoding.Default;

            var texto = utf8.GetString(buffer);
            Console.Write(texto);

*********JEITO ANTIGO********* COM BYTWS


  static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78965,4564.22,Rafael Sanzio";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }



 */
