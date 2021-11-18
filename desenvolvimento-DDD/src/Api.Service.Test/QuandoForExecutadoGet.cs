using Api.Domain.Interfaces.Services.User;
using Api.Service.Test.Usuario;
using Domain.DTO.User;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Test
{
    public class QuandoForExecutadoGet : UsuarioTestes
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock; //moka todos os metodos da IUserService, pois nao estamos batendo de fato na camada de data
        private UserDTO resultUserDTO;


        [Fact(DisplayName = "È Possivel Executar o Metodo GET.")]
        public async Task Testando_Metodo_Get()
        {

            // CENARIO 01 - VALIDAR RETORNO DE UM USUARIO
            //simulando a camada de dados
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.Get(IdUsuario)).ReturnsAsync(userDTO); // define que ao passar um idDeUsuarion devo receber um usuario | mesmo comportamento que ocorre normalmente
            _service = _serviceMock.Object;

            resultUserDTO = await _service.Get(IdUsuario); // aqui é como se fosse o resultado da data
            Assert.NotNull(resultUserDTO);
            Assert.True(IdUsuario == resultUserDTO.Id);
            Assert.Equal(NomeUsuario, resultUserDTO.Name);

            // CENARIO 02 - VALIDAR RETORNO NULL
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.Get(It.IsAny<Guid>())).Returns(Task.FromResult((UserDTO) null)); // defino que aceita qualquer GUUID e seu retorno vai ser null
            _service = _serviceMock.Object;

            resultUserDTO = await _service.Get(IdUsuario);
            Assert.Null(resultUserDTO);
            
        }
    }
}
