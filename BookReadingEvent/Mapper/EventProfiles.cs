using AutoMapper;
using BookReadingEvent.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookReadingEvent.Application.Models;

namespace BookReadingEvent.Mapper
{
    public class EventProfiles : Profile
    {

        public EventProfiles()
        {
            CreateMap<EventModel, EventViewModel>().ReverseMap();
            CreateMap<SignUpModel, SignUpViewModel>().ReverseMap();
            CreateMap<LoginModel, LoginViewModel>().ReverseMap();
            CreateMap<CommentModel, CommentViewModel>().ReverseMap();
        }
    }
}
