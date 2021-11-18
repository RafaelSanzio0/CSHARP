using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Data.Implementations;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using System;

namespace Api.CrossCutting.DependencyInjection {

    public class ConfigureRepository {
   
        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof (BaseRepository<>)); //conexao de banco e tratada como scoped | quando eu utilizar a Irepository é para instanciar a BaseRepository
            serviceCollection.AddScoped<IUserRepository, UserImplementation>();
            serviceCollection.AddScoped<IUfRepository, UfImplementation>();
            serviceCollection.AddScoped<IMunicipioRepository, MunicipioImplementation>();
            serviceCollection.AddScoped<ICepRepository, CepImplementation>();


            serviceCollection.AddDbContext<MyContext>(
                 options => options.UseSqlServer(configuration.GetConnectionString("UdemyConnection")));
        }
    }
}
