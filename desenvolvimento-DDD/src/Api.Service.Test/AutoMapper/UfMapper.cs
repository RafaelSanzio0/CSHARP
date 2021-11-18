using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Test.AutoMapper
{
    public class UfMapper : BaseTestService
    {

        [Fact(DisplayName = "É Possivel Mapear os Modelos")]
        public void E_Possivel_Mapear_os_Modelos_UF()
        {

            // CENARIO 01 - VALIDAR CONVERSAO DE MODEL PRA ENTITY

            var ufModel = new UfModel
            {
                Id = Guid.NewGuid(),
                Nome = Faker.Address.UsState(),
                Sigla = Faker.Address.UsState().Substring(1, 3),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var ufEntity = Mapper.Map<UfEntity>(ufModel);
            Assert.Equal(ufEntity.Id, ufModel.Id);
            Assert.Equal(ufEntity.Nome, ufModel.Nome);
            Assert.Equal(ufEntity.Sigla, ufModel.Sigla);
            Assert.Equal(ufEntity.CreateAt, ufModel.CreateAt);
            Assert.Equal(ufEntity.UpdateAt, ufModel.UpdateAt);


            // CENARIO 02 - VALIDAR CONVERSAO DE MODEL PRA ENTITY

            var ufEntity2 = new UfEntity
            {
                Id = Guid.NewGuid(),
                Nome = Faker.Address.UsState(),
                Sigla = Faker.Address.UsState().Substring(1, 3),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var ufModel2 = Mapper.Map<UfModel>(ufEntity2);
            Assert.Equal(ufModel2.Id, ufEntity2.Id);
            Assert.Equal(ufModel2.Nome, ufEntity2.Nome);
            Assert.Equal(ufModel2.Sigla, ufEntity2.Sigla);
            Assert.Equal(ufModel2.CreateAt, ufEntity2.CreateAt);
            Assert.Equal(ufModel2.UpdateAt, ufEntity2.UpdateAt);

        }
    }
}
