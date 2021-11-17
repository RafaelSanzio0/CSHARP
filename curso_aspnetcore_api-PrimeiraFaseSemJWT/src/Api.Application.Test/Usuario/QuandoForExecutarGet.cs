using Api.Application.Controllers;
using Api.Domain.Interfaces.Services.User;
using Domain.DTO.User;
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
    public class QuandoForExecutarGet
    {
        private UsersController _usersController;
        private Mock<IUrlHelper> _url = new Mock<IUrlHelper>();
        private Mock<IUserService> _serviceMock = new Mock<IUserService>();

        [Fact(DisplayName = "É possivel executar o GET")]
        public async Task E_Possivel_Realizar_o_Get()
        {
            var id = Guid.NewGuid();
            var nome = Faker.Name.FullName();
            var email = Faker.Name.FullName();

            // CENARIO 01 - VALIDAR GET DE USUARIO SUCESSO

            _serviceMock.Setup(mock => mock.Get(id)).ReturnsAsync(
                new UserDTO
                {
                    Id = id,
                    Name = nome,
                    Email = email,
                    CreateAt = DateTime.UtcNow
                });

            _usersController = new UsersController(_serviceMock.Object);

            var result = await _usersController.Get(id);
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value as UserDTO;
            Assert.NotNull(resultValue);
            Assert.Equal(nome, resultValue.Name);
            Assert.Equal(email, resultValue.Email);
            Assert.Equal(id, resultValue.Id);

            // CENARIO 02 - VALIDAR DELECAO DE USUARIO BADREQUEST

            _usersController.ModelState.AddModelError("id", "Formato Invalido");

            var result2 = await _usersController.Get(id);
            Assert.True(result2 is BadRequestObjectResult);
            Assert.False(_usersController.ModelState.IsValid);

        }
    }
}
