using Api.Data.Context;
using Api.Domain.Entities;
using Data.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Data.Test
{
    public class UsuarioCrudCompleto : BaseTest, IClassFixture<DbTeste> // disponibiliza acessos ao bd
    {
        public ServiceProvider _serviceProvider;

        public UsuarioCrudCompleto(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD de Usuario")]
        [Trait("Categoria CRUD", "Valor é UserEntity")]
        public async Task E_Possivel_Realizar_CRUD_Usuario()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                UserImplementation _repository = new UserImplementation(context);
                UserEntity _userEntity = new UserEntity
                {
                    Email = Faker.Internet.Email(),
                    Name = Faker.Name.FullName()
                };

                //insert
                var _registroCriado = await _repository.InsertAsync(_userEntity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(_userEntity.Email, _registroCriado.Email);
                Assert.False(_registroCriado.Id == Guid.Empty);

                //select
                var _registroObtido = await _repository.SelectAsync(_registroCriado.Id);
                Assert.NotNull(_registroObtido);
                Assert.Equal(_userEntity.Name, _registroObtido.Name);

                //selectAll
                var _todosOsRegistros = await _repository.SelectAsync();
                Assert.NotNull(_todosOsRegistros);
                Assert.True(_todosOsRegistros.Count() >= 1);

                //update
                _userEntity.Name = Faker.Name.First();
                var _registroAtualizado = await _repository.UpdateAsync(_userEntity);
                Assert.NotNull(_registroAtualizado);
                Assert.Equal(_userEntity.Name, _registroAtualizado.Name); //verifica se o novo nome do entity foi salvo no banco

                //exists
                var _registroExiste = await _repository.ExistAsync(_registroAtualizado.Id);
                Assert.True(_registroExiste);

                //delete
                var _registroDeletado = await _repository.DeleteAsync(_registroAtualizado.Id);
                Assert.True(_registroDeletado);
      
            }
        }
    }
}
