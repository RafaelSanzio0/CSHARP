using Api.Domain.Interfaces.Services.User;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection {
    public class ConfigureService {
        public static void ConfigureDependenciesService (IServiceCollection serviceCollection) {
            serviceCollection.AddTransient<IUserService, UserService> (); //cria uma nova instancia de UserService
        }
    }
}
//Objetos transitórios são sempre diferentes; uma nova instância é fornecida para todo controlador e todo serviço
//Objetos com escopo definido são os mesmos em uma solicitação, mas diferentes entre solicitações diferentes.
//Objetos Singleton são os mesmos para todos os objetos e solicitações.

