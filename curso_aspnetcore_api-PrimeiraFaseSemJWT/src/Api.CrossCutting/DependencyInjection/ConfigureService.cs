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
//Objetos transitórios são sempre diferentes; uma nova instância é fornecida para todo controlador e todo serviço
//Objetos com escopo definido são os mesmos em uma solicitação, mas diferentes entre solicitações diferentes.
//Objetos Singleton são os mesmos para todos os objetos e solicitações.

