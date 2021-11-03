using AutoMapper;
using OnionWebApi.BL.Dtos;
using OnionWebApi.Models.Entities;


namespace OnionWebApi.Services.Profiles
{
    public class BaseProfile : Profile
    {
        public BaseProfile()
        {
            #region User
            CreateMap<User, UserDto>().ReverseMap();
            #endregion
            CreateMap<Pay, PayDto>().ReverseMap();
            CreateMap<Loans, LoanDto>().ReverseMap();
            CreateMap<PayL, PayLoanDto>().ReverseMap();
       

        }
    }
}
