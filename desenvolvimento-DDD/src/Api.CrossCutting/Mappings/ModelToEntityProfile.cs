using Api.Domain.Entities;
using AutoMapper;
using Domain.Entities;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>()
                  .ReverseMap();

            CreateMap<UfModel, UfEntity>()
                  .ReverseMap();

            CreateMap<MunicipioModel, MunicipioEntity>()
                  .ReverseMap();

            CreateMap<CepModel, CepEntity>()
                  .ReverseMap();
        }
    }
}

// pegar da service para data