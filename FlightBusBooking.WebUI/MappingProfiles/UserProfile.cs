using AutoMapper;
using FlightBusBooking.Entities.Concrete;
using FlightBusBooking.WebUI.Areas.Admin.Models.UserModels;

namespace FlightBusBooking.WebUI.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserModel,AppUser>().ReverseMap();
        }
    }
}
