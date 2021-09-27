using ByteBank.Core.Model;
using ByteBank.Core.Repository;
using ByteBank.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ByteBank.View
{
    public partial class MainWindow : Window
    {
        private readonly ContaClienteRepository r_Repositorio;
        private readonly ContaClienteService r_Servico;

        public MainWindow()
        {
            InitializeComponent();

            r_Repositorio = new ContaClienteRepository();
            r_Servico = new ContaClienteService();
        }

        private void BtnProcessar_Click(object sender, RoutedEventArgs e)
        {
            var contas = r_Repositorio.GetContaClientes();

            var contasQuantidadePorThread = contas.Count() / 4; // como vou usar 4 threahds vou dividir em porcao de 4
            var contas_parte1 = contas.Take(contasQuantidadePorThread);
            var contas_parte2 = contas.Skip(contasQuantidadePorThread).Take(contasQuantidadePorThread);
            var contas_parte3 = contas.Skip(contasQuantidadePorThread*2).Take(contasQuantidadePorThread);
            var contas_parte4 = contas.Skip(contasQuantidadePorThread * 3);
            //var contas_parte1 = contas.Take(contas.Count() / 2); //pega a primeira metade da lista
            //var contas_parte2 = contas.Skip(contas.Count() / 2); // pula pra metade e pega essa metade

            var resultado = new List<string>();

            AtualizarView(new List<string>(), TimeSpan.Zero);

            var inicio = DateTime.Now;

            Thread thread_parte1 = new Thread(() => //processa a primeira metade da lista
            {
                foreach (var conta in contas_parte1)
                {
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
                    resultado.Add(resultadoProcessamento);
                }
            });

            Thread thread_parte2 = new Thread(() => //processa a segunda metade da lista
            {
                foreach (var conta in contas_parte2)
                {
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
                    resultado.Add(resultadoProcessamento);
                }
            });

            Thread thread_parte3 = new Thread(() => //processa a segunda metade da lista
            {
                foreach (var conta in contas_parte3)
                {
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
                    resultado.Add(resultadoProcessamento);
                }
            });

            Thread thread_parte4 = new Thread(() => //processa a segunda metade da lista
            {
                foreach (var conta in contas_parte4)
                {
                    var resultadoProcessamento = r_Servico.ConsolidarMovimentacao(conta);
                    resultado.Add(resultadoProcessamento);
                }
            });

            thread_parte1.Start(); // inicia o processamento da thread
            thread_parte2.Start();
            thread_parte3.Start();
            thread_parte4.Start();


            while (thread_parte1.IsAlive || thread_parte2.IsAlive || thread_parte3.IsAlive || thread_parte4.IsAlive) // verifica se as thread estao em execucao (isAlive)
            {
                Thread.Sleep(250); // ao inves de perguntar SEMPRE vamos perguntar uma vez e esperar o tempo definido com isso diminuimos 20s do processamento
            }


            var fim = DateTime.Now;

            AtualizarView(resultado, fim - inicio);
        }

        private void AtualizarView(List<String> result, TimeSpan elapsedTime)
        {
            var tempoDecorrido = $"{ elapsedTime.Seconds }.{ elapsedTime.Milliseconds} segundos!";
            var mensagem = $"Processamento de {result.Count} clientes em {tempoDecorrido}";

            LstResultados.ItemsSource = result;
            TxtTempo.Text = mensagem;
        }
    }
}

/*
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
Alteramos uma aplicação de cálculos matemáticos na execução de algumas funções paralelas a fim de tornar a aplicação responsiva!
Com a implementação da função FatorialEmParalelo(int) abaixo, obteremos qual comportamento ao chamar var a = FatorialEmParalelo(5)?
 
 * public static long FatorialEmParalelo(int valor) 
    { 
        long resultado = 0; 

        var t_calculo = new Thread(() => resultado = Fatorial(valor)); 
        t_calculo.Start(); 

        return resultado; 
    } 

private static long Fatorial(int valor)
       {
           var resultado = 1L;
           for (int i = valor; i >= 2; i--)
               resultado *= i;
           return resultado;
       }

R: Correto. A função FatorialEmParalelo retornará 0, pois ela não aguarda o término da thread t_calculo antes de retornar o valor da variável resultado, que se mantém 0
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

Você deseja criar uma Thread que não faz nada por 5 segundos. Qual a diferença dos códigos a seguir?

1.
var inicio = DateTime.Now;
while(true) {
     if (DateTime.Now - inicio >= TimeSpan.FromSeconds(5))
         break;
}

2.
Thread.Sleep(5000);

R: O código em 2. faz menor uso de recursos da CPU, indicando ao sistema operacional que aquela Thread não deve ser executada nos próximos 5 segundos
Correta. O método Thread.Sleep(int) indica ao sistema operacional que aquela Thread não deve ser executada na CPU pelos próximos 5000 milissegundos, dando prioridade para outras Threads da aplicação ou outros programas a usarem a CPU da máquina. Enquanto que no código 1.
temos um uso intensivo da CPU para o cálculo do período de tempo passado entre uma verificação e outra
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

Considere o código a seguir:

var thread = new Thread(() => Thread.Sleep(5000));
var isAlive = thread.IsAlive;
Console.WriteLine(isAlive);

Qual será o valor booleano de isAlive?
R: False. Dado que a thread não foi iniciada com o método Start, sua propriedade IsAlive nunca será true


*/