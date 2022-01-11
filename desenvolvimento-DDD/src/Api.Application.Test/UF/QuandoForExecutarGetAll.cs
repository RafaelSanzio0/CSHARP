using Application.Controllers;
using Domain.DTO.Uf;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Application.Test.UF
{
    public class QuandoForExecutarGetAll
    {
        private UfController _ufController;
        private Mock<IUfService> _ufService = new Mock<IUfService>();

        [Fact(DisplayName = "Validar GET ALL")]
        
        public async Task Validar_GetAll()
        {
            var id = Guid.NewGuid();
            var sigla = Faker.Address.CityPrefix();
            var nome = Faker.Address.City();

            var ufs = new List<UfDTO>();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UfDTO()
                {
                    Id = Guid.NewGuid(),
                    Sigla = Faker.Address.CityPrefix(),
                    Nome = Faker.Address.City()
                };

                ufs.Add(dto);
            }

            // CENARIO 01 - VALIDAR GET ALL DE USUARIO SUCESSO

            _ufService.Setup(mock => mock.GetAll()).ReturnsAsync(ufs);
            _ufController = new UfController(_ufService.Object);

            var result = await _ufController.GetAll();
            Assert.True(result is OkObjectResult);

            var resultValue = ((OkObjectResult)result).Value as IEnumerable<UfDTO>;
            Assert.NotNull(resultValue);
            Assert.True(resultValue.Count() >= 10);

            // CENARIO 02 - VALIDAR DELECAO DE USUARIO BADREQUEST

            _ufController.ModelState.AddModelError("id", "Formato Invalido");

            var result2 = await _ufController.GetAll();
            Assert.True(result2 is BadRequestObjectResult);
            Assert.False(_ufController.ModelState.IsValid);
        }
    }
}
