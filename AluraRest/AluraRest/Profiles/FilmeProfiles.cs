using AluraRest.Data.DTO;
using AluraRest.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Profiles
{
    public class FilmeProfiles : Profile
    {
        public FilmeProfiles()
        {
            // CONVERTENDO DE, PARA

            CreateMap<CreateFilmeDTO, Filme>();
            CreateMap<Filme, ReadyFilmeDTO>();
            CreateMap<UpdateFilmeDTO, Filme>();
        }
    }
}
