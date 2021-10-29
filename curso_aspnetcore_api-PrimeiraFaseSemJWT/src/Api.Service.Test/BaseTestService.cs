using AutoMapper;
using CrossCutting.Mappings;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xunit;

namespace Api.Service.Test
{
    public abstract class BaseTestService
    {
        public IMapper Mapper { get; set; }
        public IServiceCollection services{ get; set; }

        public BaseTestService()
        {
           // Mapper = new AutoMapperFixture().GetMapper(services); // chama as config do mapper
        }
    }

    public class AutoMapperFixture : IDisposable
    {
        public IMapper GetMapper(IServiceCollection services)
        {
            return (IMapper) services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        public void Dispose()
        {
            
        }
    }
}
