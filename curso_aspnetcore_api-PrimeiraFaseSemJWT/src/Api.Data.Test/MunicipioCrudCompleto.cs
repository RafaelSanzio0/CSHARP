using Api.Data.Context;
using Data.Implementations;
using Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Api.Data.Test
{
    public class MunicipioCrudCompleto : BaseTest, IClassFixture<DbTeste>
    {
        public ServiceProvider _serviceProvider;

        public MunicipioCrudCompleto(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "CRUD de Municipio")]
        [Trait("Categoria CRUD", "Valor é MunicipioEntity")]
        public async Task E_Possivel_Realizar_CRUD_Municipio()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                MunicipioImplementation repository = new MunicipioImplementation(context);
                MunicipioEntity entity = new MunicipioEntity
                {
                    Nome = Faker.Address.City(),
                    CodIBGE = Faker.RandomNumber.Next(1000000, 9999999),
                    UfID = new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6")
                };

                //insert - post
                var _registroCriado = await repository.InsertAsync(entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(entity.Nome, _registroCriado.Nome);
                Assert.Equal(entity.CodIBGE, _registroCriado.CodIBGE);
                Assert.Equal(entity.UfID, _registroCriado.UfID);
                Assert.False(_registroCriado.Id == Guid.Empty);

                //select - get
                var _registroObtido = await repository.SelectAsync(_registroCriado.Id);
                Assert.NotNull(_registroObtido);
                Assert.Equal(entity.Nome, _registroObtido.Nome);
                Assert.Equal(entity.CodIBGE, _registroObtido.CodIBGE);
                Assert.Equal(entity.UfID, _registroObtido.UfID);
                Assert.Null(_registroObtido.UfEntity);

                //selectAll - getall
                var _todosOsRegistros = await repository.SelectAsync();
                Assert.NotNull(_todosOsRegistros);
                Assert.True(_todosOsRegistros.Count() >= 1);

                //update - put
                entity.Nome = Faker.Address.City();
                var _registroAtualizado = await repository.UpdateAsync(entity);
                Assert.NotNull(_registroAtualizado);
                Assert.Equal(entity.Nome, _registroAtualizado.Nome); //verifica se o novo nome do entity foi salvo no banco

                //exists
                var _registroExiste = await repository.ExistAsync(_registroAtualizado.Id);
                Assert.True(_registroExiste);

                // GetCompleteByIBGE
                var _registroObitidoCompletoByCodIBGE = await repository.GetCompleteByIBGE(entity.CodIBGE);
                Assert.NotNull(_registroObitidoCompletoByCodIBGE);
                Assert.Equal(entity.Nome, _registroObitidoCompletoByCodIBGE.Nome);
                Assert.Equal(entity.CodIBGE, _registroObitidoCompletoByCodIBGE.CodIBGE);
                Assert.Equal(entity.UfID, _registroObitidoCompletoByCodIBGE.UfID);
                Assert.NotNull(_registroObitidoCompletoByCodIBGE.UfEntity);

                // GetCompleteByID
                var _registroObitidoCompletoByID = await repository.GetCompleteByID(entity.Id);
                Assert.NotNull(_registroObitidoCompletoByID);
                Assert.Equal(entity.Nome, _registroObitidoCompletoByID.Nome);
                Assert.Equal(entity.CodIBGE, _registroObitidoCompletoByID.CodIBGE);
                Assert.Equal(entity.UfID, _registroObitidoCompletoByID.UfID);
                Assert.NotNull(_registroObitidoCompletoByID.UfEntity);

                //delete
                var _registroDeletado = await repository.DeleteAsync(_registroAtualizado.Id);
                Assert.True(_registroDeletado);
            }
        }
    }
}

                

