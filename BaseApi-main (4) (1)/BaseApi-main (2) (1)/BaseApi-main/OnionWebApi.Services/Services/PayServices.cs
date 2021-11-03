using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using OnionWebApi.BL.Dtos;
using OnionWebApi.Models.Contexts;
using OnionWebApi.Models.Entities;
namespace OnionWebApi.Services.Services
{
	public interface IPayServices : IBaseService<Pay, PayDto> { }
	public class PayServices:  BaseServices<Pay,PayDto>,IPayServices
	
	{
		public PayServices(BaseContext baseContext, IMapper mapper) : base(baseContext, mapper)
		{

		}

	}
}
