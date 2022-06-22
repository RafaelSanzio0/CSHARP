using DesignPatters.Strategy.Models;

namespace DesignPatters.Strategy
{
    public class RealizadorDeInvestimentos
    {
        public void RealizaCalculo(Conta conta, PerfilDeInvestimento perfil)
        {
            double resultado = perfil.CalculaInvestimento(conta);
            conta.Deposita(resultado * 0.75);
        }
    }
}
