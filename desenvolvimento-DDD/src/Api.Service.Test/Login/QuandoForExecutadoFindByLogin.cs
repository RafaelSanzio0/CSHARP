using Api.Service.Test.Usuario;
using Domain.DTO;
using Domain.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Test.Login
{
    public class QuandoForExecutadoFindByLogin : UsuarioTestes
    {
        private ILoginService _service;
        private Mock<ILoginService> _serviceMock;


        [Fact(DisplayName = "È Possivel Executar o Metodo FIND BY LOGIN.")]
        public async Task Testando_Metodo_Find_By_Login()
        {
            // CENARIO 01 - VALIDAR LOGIN SUCESSO
            var successLogin = new
            {
                authenticated = true,
                create = DateTime.UtcNow,
                expiration = DateTime.UtcNow,
                acessToken = Guid.NewGuid(),
                userName = EmailUsuario,
                message = "Usuario logado com sucesso!"
            };

            var createLoginDto = new CreateLoginDTO()
            {
                Email = EmailUsuario
            };

            _serviceMock = new Mock<ILoginService>();
            _serviceMock.Setup(mock => mock.FindByLogin(createLoginDto)).ReturnsAsync(successLogin); 
            _service = _serviceMock.Object;

            var result = await _service.FindByLogin(createLoginDto); // aqui é como se fosse o resultado da data
            Assert.NotNull(result);
            Assert.Equal("Usuario logado com sucesso!",successLogin.message);
        }
    }
}
