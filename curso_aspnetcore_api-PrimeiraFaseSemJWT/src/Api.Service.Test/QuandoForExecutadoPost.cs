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
    public class QuandoForExecutadoPost : UsuarioTestes
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact(DisplayName = "È Possivel Executar o Metodo POST.")]
        public async Task Testando_Metodo_POST()
        {

            // CENARIO 01 - VALIDAR CRIACAO DE USUARIO
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.Post(createUserDTO)).ReturnsAsync(readUserCreateDTO);
            _service = _serviceMock.Object;

            var result = await _service.Post(createUserDTO);
            Assert.NotNull(result);
            Assert.Equal(NomeUsuario, result.Name);
            Assert.Equal(EmailUsuario, result.Email);

        }
    }
}
