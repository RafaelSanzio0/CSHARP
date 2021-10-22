using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;

namespace Api.CrossCutting.DependencyInjection {
    public class ConfigureService {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IUserService, UserService>(); //cria uma nova instancia de UserService
            serviceCollection.AddTransient<ILoginService, LoginService>(); //toda vez que injeto a IloginService estou fazendo uso da LoginService
        }
    }
}
//Objetos transit�rios s�o sempre diferentes; uma nova inst�ncia � fornecida para todo controlador e todo servi�o
//Objetos com escopo definido s�o os mesmos em uma solicita��o, mas diferentes entre solicita��es diferentes.
//Objetos Singleton s�o os mesmos para todos os objetos e solicita��es.

