using Xunit;
using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Tests
{
    public class VeiculoTests
    {
        /*Como o próprio nome induz [Fact], a ideia é testar um fato, algo “único” e objetivo. Esse é o recurso mais utilizado da biblioteca e pode facilmente atender todas as suas necessidades em um projeto de teste unitários.
        Com essa estrutura é possível fazer qualquer tipo de teste, porém, quando a “lógica” do teste necessita ser a mesma, modificando apenas os parâmetros de entrada, a duplicação do código de teste é inevitável.
        Obviamente em alguns casos a “duplicação” pode ser aceitável e fazer sentido, mas em sua grande maioria, não tem sentido algum ai que entra o Theory.
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
