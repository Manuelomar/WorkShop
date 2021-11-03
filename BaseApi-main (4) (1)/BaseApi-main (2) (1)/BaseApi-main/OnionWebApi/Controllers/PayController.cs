using OnionWebApi.BL.Dtos;
using OnionWebApi.Models.Entities;
using OnionWebApi.Presentation.Controllers;
using OnionWebApi.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnionWebApi.Controllers
{
	public class PayController : BaseController<Pay, PayDto>
    {
        public PayController(IPayServices service) : base(service)
        {
        }
    }
}
