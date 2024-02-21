using BusinessLogic.DTOs;
﻿using AutoMapper;
using DataAccess.Data.Entities;

namespace BusinessLogic.Mapping
{
    public class AnnouncementProfile : Profile
    {
         public AnnouncementProfile()
        {
            CreateMap<Announcement, AnnouncementDto>();
            CreateMap<AnnouncementDto, Announcement>()
                .ForMember(x => x.Category, opts => opts.Ignore());

            CreateMap<CreateAnnouncementModel, Announcement>().ReverseMap();
            CreateMap<EditAnnouncementModel, Announcement>().ReverseMap();
            CreateMap<EditAnnouncementModel, AnnouncementDto>().ReverseMap();
          
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();

        }
    }
}
