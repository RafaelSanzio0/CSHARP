using DesignPatters.Strategy.Models;

namespace DesignPatters.Strategy.Perfils
{
    internal class Conservador : PerfilDeInvestimento
    {
        public double CalculaInvestimento(Conta conta)
        {
            return conta.Saldo * 0.008;
        }
    }
}
