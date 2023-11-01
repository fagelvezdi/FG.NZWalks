using AutoMapper;
using NZWalks.Application.DTO.Walk;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.Mapping_Profiles
{
    public class WalkProfile : Profile
    {
        public WalkProfile()
        {
            CreateMap<AddOrUpdateWalkRequestDto, WalkEntity>().ReverseMap();
            CreateMap<WalkEntity, WalkDetailsDto>().ReverseMap();
        }
    }
}
