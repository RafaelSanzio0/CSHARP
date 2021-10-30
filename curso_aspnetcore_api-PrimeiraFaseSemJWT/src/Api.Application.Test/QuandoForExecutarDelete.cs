using Api.Application.Controllers;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Application.Test
{
    public class QuandoForExecutarDelete
    {
        private UsersController _usersController;
        private Mock<IUserService> _serviceMock = new Mock<IUserService>();

        [Fact(DisplayName = "É possivel executar o Delete")]
        public async Task E_Possivel_Realizar_o_Delete()
        {
            var id = Guid.NewGuid();

            // CENARIO 01 - VALIDAR DELECAO DE USUARIO SUCESSO

            _serviceMock.Setup(mock => mock.Delete(id)).ReturnsAsync(true);
            _usersController = new UsersController(_serviceMock.Object);

            var result = await _usersController.Delete(id);
            Assert.True(result is OkObjectResult);

            // CENARIO 02 - VALIDAR DELECAO DE USUARIO BADREQUEST

            _usersController.ModelState.AddModelError("id", "Formato Invalido");

            var result2 = await _usersController.Delete(id);
            Assert.True(result2 is BadRequestObjectResult);
            Assert.False(_usersController.ModelState.IsValid);

        }

    }
}
