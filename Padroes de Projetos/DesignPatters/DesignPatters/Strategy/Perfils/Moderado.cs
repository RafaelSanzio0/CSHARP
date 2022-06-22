using DesignPatters.Strategy.Models;

namespace DesignPatters.Strategy.Perfils
{
    public class Moderado : PerfilDeInvestimento
    {
        public double CalculaInvestimento(Conta conta)
        {
            var random = new Random();

            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}