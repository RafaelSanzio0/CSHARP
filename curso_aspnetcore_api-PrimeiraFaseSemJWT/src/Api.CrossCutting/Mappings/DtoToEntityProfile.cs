using Api.Domain.Entities;
using AutoMapper;
using Domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossCutting.Mappings
{
    public class DtoToEntityProfile : Profile
    {
        public DtoToEntityProfile()
        {
            CreateMap<CreateUserDTO, UserEntity>()
                .ReverseMap();

            CreateMap<ReadUserCreateDTO, UserEntity>()
                .ReverseMap();

            CreateMap<ReadUserUpdateDTO, UserEntity>()
                .ReverseMap();

            CreateMap<UserDTO, UserEntity>()
                .ReverseMap();
        }
    }
}

// to la na data eu devolvo o resultado como DTO