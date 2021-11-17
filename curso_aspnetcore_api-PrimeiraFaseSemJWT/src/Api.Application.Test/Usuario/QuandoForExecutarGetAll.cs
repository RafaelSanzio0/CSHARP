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
    public class QuandoForExecutarGetAll
    {
        private UsersController _usersController;
        private Mock<IUrlHelper> _url = new Mock<IUrlHelper>();
        private Mock<IUserService> _serviceMock = new Mock<IUserService>();

        [Fact(DisplayName = "É possivel executar o GET ALL")]
        public async Task E_Possivel_Realizar_o_Get_All()
        {
            var id = Guid.NewGuid();
            var nome = Faker.Name.FullName();
            var email = Faker.Name.FullName();

            var usuarios = new List<UserDTO>();

            for (int i = 0; i < 10; i++) 
            {
                var dto = new UserDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email()
                };

                usuarios.Add(dto);
            }

            // CENARIO 01 - VALIDAR GET ALL DE USUARIO SUCESSO

            _serviceMock.Setup(mock => mock.GetAll()).ReturnsAsync(usuarios);
            _usersController = new UsersController(_serviceMock.Object);

            var result = await _usersController.GetAll();
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value as IEnumerable<UserDTO>;
            Assert.NotNull(resultValue);
            Assert.True(resultValue.Count() >= 10);
           

            // CENARIO 02 - VALIDAR DELECAO DE USUARIO BADREQUEST

            _usersController.ModelState.AddModelError("id", "Formato Invalido");

            var result2 = await _usersController.GetAll();
            Assert.True(result2 is BadRequestObjectResult);
            Assert.False(_usersController.ModelState.IsValid);

        }
    }
}
