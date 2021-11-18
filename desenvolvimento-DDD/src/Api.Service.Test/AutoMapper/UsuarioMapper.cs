using Api.Domain.Entities;
using Api.Service.Test.Usuario;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Service.Test.AutoMapper
{
    public class UsuarioMapper : BaseTestService
    {
        [Fact(DisplayName = "È Possivel Mapear os Modelos")]
        public void E_Possivel_Mapear_os_Modelos()
        {

            // CENARIO 01 - VALIDAR CONVERSAO DE MODEL PARA ENTITY
            // aqui estou verificando se todos os dados durante a conversao ocorreu bem
            var userModel = new UserModel
            {
                Id = Guid.NewGuid(),
                Name = Faker.Name.FullName(),
                Email = Faker.Internet.Email(),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var modelToEntity = Mapper.Map<UserEntity>(userModel);
            Assert.Equal(modelToEntity.Id, userModel.Id);
            Assert.Equal(modelToEntity.Name, userModel.Name);
            Assert.Equal(modelToEntity.Email, userModel.Email);
            Assert.Equal(modelToEntity.CreateAt, userModel.CreateAt);
            Assert.Equal(modelToEntity.UpdateAt, userModel.UpdateAt);

            // CENARIO 02 - VALIDAR CONVERSAO DE ENTITY PARA MODEL
            var userEntity = new UserEntity
            {
                Id = Guid.NewGuid(),
                Name = Faker.Name.FullName(),
                Email = Faker.Internet.Email(),
                CreateAt = DateTime.UtcNow,
                UpdateAt = DateTime.UtcNow
            };

            var entityToModel = Mapper.Map<UserModel>(userEntity);
            Assert.Equal(entityToModel.Id, userEntity.Id);
            Assert.Equal(entityToModel.Name, userEntity.Name);
            Assert.Equal(entityToModel.Email, userEntity.Email);
            Assert.Equal(entityToModel.CreateAt, userEntity.CreateAt);
            Assert.Equal(entityToModel.UpdateAt, userEntity.UpdateAt);
        }

    }
}

// fluxo é DTO > MODEL > ENTITY
