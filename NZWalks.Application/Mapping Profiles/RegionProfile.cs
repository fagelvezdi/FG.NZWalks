using AutoMapper;
using NZWalks.Application.DTO.Region;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.Mapping_Profiles
{
    public class RegionProfile : Profile
    {
        public RegionProfile()
        {
            CreateMap<RegionEntity, RegionDetailsDto>().ReverseMap();
            CreateMap<AddOrUpdateRegionDto, RegionEntity>().ReverseMap();
        }
    }
}
