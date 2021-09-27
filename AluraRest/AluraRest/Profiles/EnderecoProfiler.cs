using AluraRest.Data.DTO;
using AluraRest.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Profiles
{
    public class EnderecoProfiler : Profile
    {
        public EnderecoProfiler()
        {
            CreateMap<CreateEnderecoDTO, Endereco>();
            CreateMap<Endereco, ReadyEnderecoDTO>();
            CreateMap<UpdateEnderecoDTO, Endereco>();
        }
    }
}
