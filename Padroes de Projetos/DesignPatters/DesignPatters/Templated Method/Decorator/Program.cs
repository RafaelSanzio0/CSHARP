using DesignPatters.Templated_Method;

namespace DesignPatters.Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Imposto iccpComIckv = new ICPP(new IKCV()); // quero acoplar o comportamento de uma classe em outras

            double orcamento = 500.0;

            double valor = iccpComIckv.Calcula(orcamento);

            Console.WriteLine(valor);
        }
    }
}
