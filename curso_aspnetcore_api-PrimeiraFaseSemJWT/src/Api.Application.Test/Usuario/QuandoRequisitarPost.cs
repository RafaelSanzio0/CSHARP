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
    public class QuandoRequisitarPost
    {
        private UsersController _usersController;
        private Mock<IUrlHelper> _url = new Mock<IUrlHelper>();


        [Fact(DisplayName = "É possivel executar o POST")]
        public async Task E_Possivel_Realizar_o_Post()
        {
            var serviceMock = new Mock<IUserService>(); //mock da service
            var nome = Faker.Name.FullName();
            var email = Faker.Name.FullName();

            // CENARIO 01 - VALIDAR CRIACAO DE USUARIO SUCESSO
            serviceMock.Setup(mock => mock.Post(It.IsAny<CreateUserDTO>())).ReturnsAsync(
                new ReadUserCreateDTO
                {
                    Id = Guid.NewGuid(),
                    Name = nome,
                    Email = email,
                    CreateAt = DateTime.UtcNow
                }
             );

            _usersController = new UsersController(serviceMock.Object); //controller recebe um service
            _url.Setup(mock => mock.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000"); //criando uma url pq o metodo created precisa de uma
            _usersController.Url = _url.Object; // controler recebe um url

            //massa do teste da controller
            var createUserDTO = new CreateUserDTO
            {
                Name = nome,
                Email = email
            };

            //chama de fato o metodo post da controller
            var result = await _usersController.Post(createUserDTO);
            Assert.True(result is CreatedResult);

            var resultValue = ((CreatedResult)result).Value as ReadUserCreateDTO;
            Assert.NotNull(resultValue);
            Assert.Equal(createUserDTO.Name, resultValue.Name);
            Assert.Equal(createUserDTO.Email, createUserDTO.Email);


            // CENARIO 02 - VALIDAR CRIACAO DE USUARIO BADREQUEST

            _usersController.ModelState.AddModelError("Name", "Campo obrigatorio");

            var result2 = await _usersController.Post(createUserDTO);
            Assert.True(result2 is BadRequestObjectResult);

        }
    }
}
