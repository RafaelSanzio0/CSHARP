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
    public class UfGets : BaseTest, IClassFixture<DbTeste>
    {
        public ServiceProvider _serviceProvider;

        public UfGets(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "GET de Uf")]
        [Trait("Categoria GET", "Valor é UfEntity")]
        public async Task E_Possivel_Realizar_GET_UF()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                UfImplementation _repository = new UfImplementation(context);
                UfEntity entity = new UfEntity
                {
                    Id = new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                    Sigla = "SP",
                    Nome = "São Paulo",
                    CreateAt = DateTime.UtcNow
                };

                // exists
                var registroExist = await _repository.ExistAsync(entity.Id);
                Assert.True(registroExist);

                // get
                var registoSelecionado = await _repository.SelectAsync(entity.Id);
                Assert.Equal(entity.Id, registoSelecionado.Id);
                Assert.Equal(entity.Sigla, registoSelecionado.Sigla);
                Assert.Equal(entity.Nome, registoSelecionado.Nome);

                // get all
                var registrosSelecionados = await _repository.SelectAsync();
                Assert.True(registrosSelecionados.Count() == 27);
            }
        }
    }
}
