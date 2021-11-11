using Api.Domain.Entities;
using AutoMapper;
using Domain.DTO.Cep;
using Domain.DTO.Municipio;
using Domain.DTO.Uf;
using Domain.DTO.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Mappings
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            // USER
            CreateMap<CreateUserDTO, UserEntity>()
                .ReverseMap();

            CreateMap<ReadUserCreateDTO, UserEntity>()
                .ReverseMap();

            CreateMap<ReadUserUpdateDTO, UserEntity>()
                .ReverseMap();

            CreateMap<UserDTO, UserEntity>()
                .ReverseMap();

            // UF
            CreateMap<UfDTO, UfEntity>()
                .ReverseMap();

            // Municipio
            CreateMap<MunicipioDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOCompleto, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOCreate, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOCreateResult, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOUpdate, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOUpdateResult, MunicipioEntity>()
                .ReverseMap();

            // Cep
            CreateMap<CepDTO, CepEntity>()
               .ReverseMap();

            CreateMap<CepDTOCreate, CepEntity>()
                .ReverseMap();

            CreateMap<CepDTOCreateResult, CepEntity>()
                .ReverseMap();

            CreateMap<CepDTOUpdate, CepEntity>()
                .ReverseMap();

            CreateMap<CepDTOUpdateResult, CepEntity>()
                .ReverseMap();
        }
    }
}

// to la na data eu devolvo o resultado como DTO ou vice versa