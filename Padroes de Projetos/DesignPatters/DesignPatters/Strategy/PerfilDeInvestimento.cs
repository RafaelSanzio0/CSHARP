using DesignPatters.Strategy.Models;

namespace DesignPatters.Strategy
{
    public interface PerfilDeInvestimento
    {
        double CalculaInvestimento(Conta conta);
    }
}
