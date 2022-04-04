using Xunit;
using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTests
    {
        /*Como o pr�prio nome induz [Fact], a ideia � testar um fato, algo ��nico� e objetivo. Esse � o recurso mais utilizado da biblioteca e pode facilmente atender todas as suas necessidades em um projeto de teste unit�rios.
        Com essa estrutura � poss�vel fazer qualquer tipo de teste, por�m, quando a �l�gica� do teste necessita ser a mesma, modificando apenas os par�metros de entrada, a duplica��o do c�digo de teste � inevit�vel.
        Obviamente em alguns casos a �duplica��o� pode ser aceit�vel e fazer sentido, mas em sua grande maioria, n�o tem sentido algum ai que entra o Theory.
         */
        [Fact] 
        public void TestaAcelerar()
        {
            // arrange
            var veiculo = new Veiculo();

            // action
            veiculo.Acelerar(10); //quando o retorno do metodo e void e nao consigo atribuir a var posso validar o result pelo atributo

            // assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaFrear()
        {
            // arrange
            var veiculo = new Veiculo();

            // action
            veiculo.Frear(10);

            // assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaTipoVeiculo()
        {
            // arrange
            var veiculo = new Veiculo();
            var tipoEsperado = TipoVeiculo.Automovel;

            // action 
            // (objeto criado sem o tipo)

            // assert
            Assert.Equal(tipoEsperado, veiculo.Tipo);
        }
    }
}
