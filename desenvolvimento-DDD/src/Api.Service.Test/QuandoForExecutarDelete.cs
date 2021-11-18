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
    public class QuandoForExecutarDelete : UsuarioTestes
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;
        private bool result;

        [Fact(DisplayName = "È Possivel Executar o Metodo DELETE.")]
        public async Task Testando_Metodo_Delete()
        {

            // CENARIO 01 - VALIDAR REMOCAO DE USUARIO
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.Delete(IdUsuario)).ReturnsAsync(true); //implementando o metodo delete ou seja se eu receber o id de usuario retorno true
            _service = _serviceMock.Object;

            result = await _service.Delete(IdUsuario);
            Assert.True(result);

            // CENARIO 02 - VALIDAR REMOCAO DE USUARIO COM ID INEXISTENTE
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.Delete(It.IsAny<Guid>())).ReturnsAsync(false);
            _service = _serviceMock.Object;

            result = await _service.Delete(IdUsuario);
            Assert.False(result);
        }
    }
}

//Na Service você irá estar testando o Retorno do Método se ele está conseguindo dar o Retorno do que está entrado e saindo.