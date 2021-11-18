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
            #region User
            CreateMap<ReadUserCreateDTO, UserEntity>()
                .ReverseMap();

            CreateMap<ReadUserUpdateDTO, UserEntity>()
                .ReverseMap();

            CreateMap<UserDTO, UserEntity>()
                .ReverseMap();
            #endregion

            #region Uf
            CreateMap<UfDTO, UfEntity>()
                .ReverseMap();
            #endregion

            #region Municipio
            CreateMap<MunicipioDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOCompleto, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTOCreateResult, MunicipioEntity>()
                .ReverseMap();
      
            CreateMap<MunicipioDTOUpdateResult, MunicipioEntity>()
                .ReverseMap();
            #endregion

            #region Cep
            CreateMap<CepDTO, CepEntity>()
               .ReverseMap();

            CreateMap<CepDTOCreateResult, CepEntity>()
                .ReverseMap();

            CreateMap<CepDTOUpdateResult, CepEntity>()
                .ReverseMap();
            #endregion
        }
    }
}

// to la na data eu devolvo o resultado como DTO ou vice versa
// nao colocamos o create e update pois a entidade devolve para os result pq o create e update é recebido la na API