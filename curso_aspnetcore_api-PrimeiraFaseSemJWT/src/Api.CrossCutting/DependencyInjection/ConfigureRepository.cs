using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection {
    public class ConfigureRepository {
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof (BaseRepository<>)); //conexao de banco e tratada como scoped | quando eu utilizar a Irepository é para instanciar a BaseRepository

            serviceCollection.AddDbContext<MyContext> (
                 options => options.UseMySql("server=localhost;database=UdemyDB;user=root;password=root")
            );
        }
    }
}
