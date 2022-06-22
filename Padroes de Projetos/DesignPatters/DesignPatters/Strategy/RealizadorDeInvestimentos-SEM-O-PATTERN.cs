using DesignPatters.Strategy.Models;

namespace DesignPatters.Strategy
{
    public class RealizadorDeInvestimentos_SEM_O_PATTERN
    {
        public void RealizaCalculo(Conta conta, string perfil)
        {
            var random = new Random();

            if (perfil.Equals("CONSERVADOR"))
            {
                var resultado = (conta.Saldo * 0.008) * 0.75;
                conta.Deposita(resultado);
            }
            else if(perfil.Equals("MODERADO"))
            {
                double resultado;

                if (random.Next(2) == 0)
                {
                    resultado = (conta.Saldo * 0.025) * 0.75;
                    conta.Deposita(resultado);
                }
                else
                {
                    resultado = (conta.Saldo * 0.007) * 0.75;
                    conta.Deposita(resultado);
                }        
            }
            else if (perfil.Equals("ARROJADO"))
            {
                double resultado;
                int chute = random.Next(10);

                if (chute >= 0 && chute <= 1)
                {
                    resultado = (conta.Saldo * 0.5) * 0.75;
                    conta.Deposita(resultado);
                }
                else if (chute >= 2 && chute <= 4)
                {
                    resultado = (conta.Saldo * 0.3) * 0.75;
                    conta.Deposita(resultado);
                }
                else {
                    resultado = (conta.Saldo * 0.006) * 0.75;
                    conta.Deposita(resultado);
                }
            }
        }
    }
}
