using Api.Domain.Interfaces.Services.User;
using Api.Service.Test.Usuario;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Test
{
    public class QuandoForExecutadoPut : UsuarioTestes
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact(DisplayName = "È Possivel Executar o Metodo PUT.")]
        public async Task Testando_Metodo_PUT()
        {

            // CENARIO 01 - VALIDAR ATUALIZACAO DE USUARIO
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.Put(updateUserDTO)).ReturnsAsync(readUserUpdateDTO);
            _service = _serviceMock.Object;

            var result = await _service.Put(updateUserDTO);
            Assert.NotNull(result);
            Assert.Equal(NomeUsuarioAlterado, result.Name);
            Assert.Equal(EmailUsuarioAlterado, result.Email);

        }
    }
}
