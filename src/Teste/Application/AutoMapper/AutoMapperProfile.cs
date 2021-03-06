using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerViewModel>()
                .ForMember(s => s.AddressViewModel, t => t.MapFrom(e => e.Address))
                .ForMember(s => s.PhoneViewModel, t => t.MapFrom(e => e.Phone)).ReverseMap();

            CreateMap<Phone, PhoneViewModel>().ReverseMap();

            CreateMap<Address, AddressViewModel>().ReverseMap();


        }
    }
}
