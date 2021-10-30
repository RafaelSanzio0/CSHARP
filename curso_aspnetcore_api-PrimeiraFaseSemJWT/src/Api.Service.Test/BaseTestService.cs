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
            Mapper = new AutoMapperFixture().GetMapper(); // chama as config do mapper
        }
    }

    public class AutoMapperFixture : IDisposable
    {
        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(config =>
            {
                config.AddProfile(new ModelToEntityProfile());
                config.AddProfile(new DtoToEntityProfile());
                config.AddProfile(new DtoToModelProfile());
            });

            return config.CreateMapper();
        }

        public void Dispose()
        {
            
        }
    }
}
