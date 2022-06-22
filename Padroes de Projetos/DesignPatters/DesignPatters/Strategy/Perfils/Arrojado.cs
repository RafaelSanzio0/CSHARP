using DesignPatters.Strategy.Models;

namespace DesignPatters.Strategy.Perfils
{
    public class Arrojado : PerfilDeInvestimento
    {
        public double CalculaInvestimento(Conta conta)
        {
            var random = new Random();

            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1) return conta.Saldo * 0.5;
            else if (chute >= 2 && chute <= 4) return conta.Saldo * 0.3;
            else return conta.Saldo * 0.006;
        }
    }
}
