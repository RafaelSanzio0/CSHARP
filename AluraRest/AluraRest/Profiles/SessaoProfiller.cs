using AluraRest.Data.DTO;
using AluraRest.Data.DTO.Sessao;
using AluraRest.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Profiles
{
    public class SessaoProfiller : Profile
    {
        public SessaoProfiller()
        {
            CreateMap<CreateSessaoDTO, Sessao>();
            CreateMap<Sessao, ReadSessaoDTO>()
                .ForMember(dto => dto.HorarioDeInicio, opts => opts // para a propriedade horarioInicio eu quero atribuir um valor em tempo de runtime
                .MapFrom(dto => dto.HorarioDeEncerramento.AddMinutes(dto.Filme.Duracao * (-1)))); // esse valor sera o meu horario de encerramento 2002-01-01T21:30:00Z - 180 minutos = 18:30
        }
   
    }
}
