using AutoMapper;
using ECommerceMVC.Data;
using ECommerceMVC.ViewModels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ECommerceMVC.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterVM, KhachHang>();
            //.ForMember(kh => kh.HoTen, option => option.MapFrom(RegisterVM => RegisterVM.HoTen))
            //.ReverseMap();
        }
    }
}