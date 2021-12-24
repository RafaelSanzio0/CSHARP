using AutoMapper;
using Domain.Dto.Cinema;
using Domain.Dto.Endereco;
using Domain.Dto.Filme;
using Domain.Dto.Gerente;
using Domain.Dto.Sessao;
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
            #region Cinema
            CreateMap<ResultCreateCinemaDto, CinemaEntity>()
                .ReverseMap();
            CreateMap<ResultUpdateCinemaDto, CinemaEntity>()
                .ReverseMap();
            CreateMap<CinemaDto, CinemaEntity>()
                .ReverseMap();
            #endregion

            #region Endereco
            CreateMap<ResultCreateEnderecoDto, EnderecoEntity>()
                .ReverseMap();
            CreateMap<ResultUpdateEnderecoDto, EnderecoEntity>()
                .ReverseMap();
            CreateMap<EnderecoDto, EnderecoEntity>()
                .ReverseMap();
            #endregion

            #region Filme
            CreateMap<ResultCreateFilmeDto, FilmeEntity>()
                .ReverseMap();
            CreateMap<ResultUpdateFilmeDto, FilmeEntity>()
                .ReverseMap();
            CreateMap<FilmeDto, FilmeEntity>()
                .ReverseMap();
            #endregion

            #region Gerente
            CreateMap<ResultCreateGerenteDto, GerenteEntity>()
                .ReverseMap();
            CreateMap<ResultUpdateGerenteDto, GerenteEntity>()
                .ReverseMap();
            CreateMap<GerenteDto, GerenteEntity>()
                .ReverseMap();
            #endregion

            #region Sessao
            CreateMap<ResultCreateSessaoDto, SessaoEntity>()
                .ReverseMap();
            CreateMap<ResultUpdateSessaoDto, SessaoEntity>()
                .ReverseMap();
            CreateMap<SessaoDto, SessaoEntity>()
                .ReverseMap();
            #endregion
        }

    }
}
