using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario // abstract é uma classe que nao permite ser instanciada.
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; protected set; } // legal de usar o protecd é que as classe filhas conseguem manipular a variavel. Exemplo dentro do metudo aumentarSalario da classe filha
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO"); // toda classe derivada de funcionario chama automaticamente o construtor base
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public Funcionario(string cpf) : this(1500, cpf)// Construtor sem salário!
        {
            Console.WriteLine("Construtor sem salario chamado");
           // Salario = 1500; // Este é nosso valor padrão, definido apenas aqui!
           // CPF = cpf; *****EVITANDO A REPETICAO DE CODIGO, BASTA CHAMAR O CONSTRUTOR COM MAIS ARGUMENTO COM A PALAVRA THIS PASSANDO ALGUNS VALORES PADRAO******

           //TotalDeFuncionarios++;

        }

        // A LOGICA DO METUDO ABSTRADO É OBRIGAR TODA CLASSE FILHA A TER UMA IMPLEMENTACAO DESSES METUDOS E RETIRAR A LOGICA NAO USADA E QUE NAO FAZ SENTIDO NOS METUDOS DA CLASSE PAI
        internal protected abstract double GetBonificacao(); // acessivel somente internamente .modelos e a classes derivadas > na classe derivada chamar por protected | dentro do .modelos declara o metodo override como protected internal e fora dele como protected apenas
        public abstract void AumentarSalario();

        // EXEMPLO DE METUDOS VIRTUAL
        //public abstract virtual double GetBonificacao() // permito que exista metudos override por conta do virtual
        //{
        //    return Salario * 0.10;
        //}

        //public abstract virtual void AumentarSalario()
        //{
        //    //Salario = Salario + (Salario * 0.1); SAO EQUIVALENTES AS 3 OPCOES
        //    //Salario = Salario * 1.1; CARREGANDO O Salario dentro do 1 no --> "1.1"
        //    Salario *= 1.1;
    }
}

