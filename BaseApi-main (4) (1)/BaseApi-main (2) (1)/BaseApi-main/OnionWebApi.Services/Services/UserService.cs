using AutoMapper;
using OnionWebApi.BL.Dtos;
using OnionWebApi.Models.Contexts;
using OnionWebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionWebApi.Services.Services
{
    public interface IUserService: IBaseService<User, UserDto> { }
	public class UserService : BaseServices<User, UserDto>, IUserService
	{
		public UserService(BaseContext baseContext, IMapper mapper) : base(baseContext, mapper) 
		{ 

		}

	}
}
