using Xunit;
using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using System;

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
        [Trait("Funcionalidade", "frear")]
        public void TestaFrear()
        {
            // arrange
            var veiculo = new Veiculo();

            // action
            veiculo.Frear(10);

            // assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "TESTE 2")] // ALTERA O NOME EXIBIDO NO GERENCIADOR DE TESTE
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

        [Theory]
        [InlineData("agr1","arg2","arg3")]
        [InlineData("agr4", "arg5", "arg6")]
        public void Testa(string arg, string args, string argsss)
        {

        }

        [Fact(Skip = "teste n implementado")]
        public void TestSkip()
        {
            
        }

        public void AssertComException()
        {
            // Assert
            Assert.Throws<Exception>(
                () => new Veiculo("ab").Acelerar(3)
            );;
                
        }
    }
}
