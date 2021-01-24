using System;
using Ada.Webpage.Models;
using Application.Models;
using AutoMapper;
using PostSummary = Ada.Webpage.Models.PostSummary;

namespace Ada.Webpage.Mappers
{
    internal class HomeMapperProfile : Profile
    {
        public HomeMapperProfile()
        {
            CreateMap<Banner, BannerItem>()
                .ForMember(i => i.Title, o => o.MapFrom(src => src.Title))
                .ForMember(i => i.Description, o => o.MapFrom(src => src.Description))
                .ForMember(i => i.Image,
                    o => o.MapFrom(src => string.IsNullOrEmpty(src.HeaderUri) ? null : new Uri(src.HeaderUri)));

            CreateMap<Application.Models.PostSummary, PostSummary>()
                .ForMember(i => i.Title, o => o.MapFrom(src => src.Title))
                .ForMember(i => i.Description, o => o.MapFrom(src => src.Summary))
                .ForMember(i => i.Header,
                    o => o.MapFrom(src =>
                        string.IsNullOrEmpty(src.HeaderImageUri) ? null : new Uri(src.HeaderImageUri)))
                .ForMember(i => i.PostUri, o => o.Ignore());

            CreateMap<HomeModel, HomeViewModel>();
        }
    }
}