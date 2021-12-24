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
            CreateMap<CinemaModel, CinemaEntity>()
                  .ReverseMap();

            CreateMap<EnderecDto, EnderecoEntity>()
                  .ReverseMap();

            CreateMap<FilmeModel, FilmeEntity>()
                  .ReverseMap();

            CreateMap<GerenteModel, GerenteEntity>()
                  .ReverseMap();

            CreateMap<SessaoModel, SessaoEntity>()
                  .ReverseMap();
        }
    }
}
