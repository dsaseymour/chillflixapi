using System;
using AutoMapper;
using Entities.Dtos;
using Entities.Models;

namespace Chillflixapi
{
    public class MappingProfile : AutoMapper.Profile  
    {
        public MappingProfile()
        {

            CreateMap<User, UserDto>();
            CreateMap<UserForCreationDto,User>();


        }
    }
}
