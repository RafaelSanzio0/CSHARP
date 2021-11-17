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
    public class QuandoForExecutarPut
    {
        private UsersController _usersController;
        private Mock<IUserService> _serviceMock = new Mock<IUserService>();

        [Fact(DisplayName = "É possivel executar o PUT")]
        public async Task E_Possivel_Realizar_o_Put()
        {
            var nome = Faker.Name.FullName();
            var email = Faker.Name.FullName();
            var id = Guid.NewGuid();

            _serviceMock.Setup(mock => mock.Put(It.IsAny<UpdateUserDTO>())).ReturnsAsync(
                new ReadUserUpdateDTO
                {
                    Id = id,
                    Name = nome,
                    Email = email,
                    UpdateAt = DateTime.UtcNow
                }
             );

            _usersController = new UsersController(_serviceMock.Object); 

            var updateUserDTO = new UpdateUserDTO
            {
                id = id,
                Name = nome,
                Email = email,
            };

            // CENARIO 01 - VALIDAR CRIACAO DE USUARIO SUCESSO

            var result = await _usersController.Put(updateUserDTO);
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value as ReadUserUpdateDTO;
            Assert.NotNull(resultValue);
            Assert.Equal(updateUserDTO.Name, resultValue.Name);
            Assert.Equal(updateUserDTO.Email, resultValue.Email);
            Assert.Equal(updateUserDTO.id, resultValue.Id);

            // CENARIO 02 - VALIDAR CRIACAO DE USUARIO BADREQUEST

            _usersController.ModelState.AddModelError("Name", "Campo obrigatorio");

            var result2 = await _usersController.Put(updateUserDTO);
            Assert.True(result2 is BadRequestObjectResult);
            Assert.False(_usersController.ModelState.IsValid);


        }
    }
}
