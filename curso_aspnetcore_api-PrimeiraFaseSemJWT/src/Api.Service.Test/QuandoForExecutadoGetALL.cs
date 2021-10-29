using Api.Domain.Interfaces.Services.User;
using Api.Service.Test.Usuario;
using Domain.DTO.User;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Test
{
    public class QuandoForExecutadoGetALL : UsuarioTestes
    {
        private IUserService _service;
        private Mock<IUserService> _serviceMock;

        [Fact(DisplayName = "È Possivel Executar o Metodo GET ALL.")]
        public async Task Testando_Metodo_Get_All()
        {

            // CENARIO 01 - VALIDAR RETORNO DE LISTA COM USUARIOS
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.GetAll()).ReturnsAsync(listaUserDTO); // quando eu chamar o getAll devo retornar uma lista de usuarios
            _service = _serviceMock.Object;

            var result = await _service.GetAll(); //A questão aqui é se o testes está entrando no método e fazendo o retorno corretamente.
            Assert.NotNull(result);
            Assert.True(result.Count() >= 10);

            // CENARIO 02 - VALIDAR RETORNO DE LISTA VAZIA
            var listaVazia = new List<UserDTO>();
            _serviceMock = new Mock<IUserService>();
            _serviceMock.Setup(mock => mock.GetAll()).ReturnsAsync(listaVazia.AsEnumerable());
            _service = _serviceMock.Object;

            var result2 = await _service.GetAll();
            Assert.Empty(listaVazia);
            Assert.True(listaVazia.Count() == 0);
        }
    }
}
