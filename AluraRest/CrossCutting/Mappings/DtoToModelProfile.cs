using AutoMapper;
using Domain.Dto.Cinema;
using Domain.Dto.Endereco;
using Domain.Dto.Filme;
using Domain.Dto.Gerente;
using Domain.Dto.Sessao;
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
            #region Cinema
            CreateMap<CreateCinemaDto, CinemaModel>()
                .ReverseMap();
            CreateMap<UpdateCinemaDto, CinemaModel>()
                .ReverseMap();
            CreateMap<CinemaDto, CinemaModel>()
                .ReverseMap();
            #endregion

            #region Endereco
            CreateMap<CreateEnderecoDto, EnderecDto>()
                .ReverseMap();
            CreateMap<UpdateEnderecoDto, EnderecDto>()
                .ReverseMap();
            CreateMap<EnderecoDto, EnderecDto>()
                .ReverseMap();
            #endregion

            #region Filme
            CreateMap<CreateFilmeDto, FilmeModel>()
                .ReverseMap();
            CreateMap<UpdateFilmeDto, FilmeModel>()
                .ReverseMap();
            CreateMap<FilmeDto, FilmeModel>()
                .ReverseMap();
            #endregion

            #region Gerente
            CreateMap<CreateGerenteDto, GerenteModel>()
                .ReverseMap();
            CreateMap<UpdateGerenteDto, GerenteModel>()
                .ReverseMap();
            CreateMap<GerenteDto, GerenteModel>()
                .ReverseMap();
            #endregion

            #region Sessao
            CreateMap<CreateSessaoDto, SessaoModel>()
                .ReverseMap();
            CreateMap<UpdateSessaoDto, SessaoModel>()
                .ReverseMap();
            CreateMap<SessaoDto, SessaoModel>()
                .ReverseMap();
            #endregion

        }
    }
}
