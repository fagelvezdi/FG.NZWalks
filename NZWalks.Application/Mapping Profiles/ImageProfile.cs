using AutoMapper;
using NZWalks.Application.DTO.Image;
using NZWalks.Application.DTO.Region;
using NZWalks.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZWalks.Application.Mapping_Profiles
{
    public class ImageProfile : Profile
    {
        public ImageProfile() 
        {
            CreateMap<ImageUploadRequestDto, Image>().ReverseMap();

        }
    }
}
