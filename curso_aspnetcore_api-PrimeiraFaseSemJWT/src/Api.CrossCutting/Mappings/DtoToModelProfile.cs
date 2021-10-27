using AutoMapper;
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
            CreateMap<CreateUserDTO, UserModel>()  //converte do <source, destino>
                .ReverseMap();  // conversao ao contraria
            CreateMap<UpdateUserDTO, UserModel>()  
                .ReverseMap();
            CreateMap<UserDTO, UserModel>()
                .ReverseMap();
        }
    }
}


// entrada da controler pra service