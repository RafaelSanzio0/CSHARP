using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Api.Data.Test
{
    public abstract class BaseTest
    {
        public BaseTest()
        {

        }
    }

    public class DbTeste : IDisposable
    {
        private string dataBaseName = $"dbUdemyTest_ {Guid.NewGuid().ToString().Replace("-", string.Empty)}";
        public ServiceProvider ServiceProvider { get; private set; }

        public DbTeste()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<MyContext>(
                 options => options.UseSqlServer($"Server=.\\SQLEXPRESS2017;Initial Catalog={dataBaseName};User ID=sa;Password=root;MultipleActiveResultSets=true"),
                    ServiceLifetime.Transient); //cria um bd pra cada requisicao

            ServiceProvider = serviceCollection.BuildServiceProvider();
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureCreated(); // fluxo pega a string de conexao > buildado pelo serviceProdiver > pega o contexto do myContext > cria o banco e faz a migration
            }
        }

        public void Dispose()
        {
            using (var context = ServiceProvider.GetService<MyContext>())
            {
                context.Database.EnsureDeleted(); // garante que o banco foi deletado
            }
        }
    }
}
