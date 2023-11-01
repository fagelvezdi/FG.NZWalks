using AutoMapper;
using NZWalks.Application.DTO.Difficulty;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.Mapping_Profiles
{
    public class DifficultyProfile : Profile
    {
        public DifficultyProfile() 
        { 
            CreateMap<DifficultyEntity, DifficultyDetailsDto>();
        }
    }
}
