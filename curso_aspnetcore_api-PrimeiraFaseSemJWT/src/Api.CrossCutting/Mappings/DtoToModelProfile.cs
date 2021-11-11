using AutoMapper;
using Domain.DTO.Cep;
using Domain.DTO.Municipio;
using Domain.DTO.Uf;
using Domain.DTO.User;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            CreateMap<CreateUserDTO, UserModel>()  //converte do <source, destino>
                .ReverseMap(); // conversao ao contraria

            CreateMap<UpdateUserDTO, UserModel>()  
                .ReverseMap();

            CreateMap<UserDTO, UserModel>()
                .ReverseMap();
            #endregion

            #region Uf
            CreateMap<UfDTO, UfModel>()
                .ReverseMap();
            #endregion

            #region Municipio
            CreateMap<MunicipioDTOCreate, MunicipioModel>()
                .ReverseMap();

            CreateMap<MunicipioDTOCompleto, MunicipioModel>()
                .ReverseMap();

            CreateMap<MunicipioDTO, MunicipioModel>()
                .ReverseMap();

            CreateMap<MunicipioDTOUpdate, MunicipioModel>()
                .ReverseMap();
            #endregion

            #region Cep
            CreateMap<CepDTO, CepModel>()
                .ReverseMap();

            CreateMap<CepDTOCreate, CepModel>()
                .ReverseMap();

            CreateMap<CepDTOUpdate, CepModel>()
                .ReverseMap();
            #endregion
        }
    }
}


// entrada da controler pra service