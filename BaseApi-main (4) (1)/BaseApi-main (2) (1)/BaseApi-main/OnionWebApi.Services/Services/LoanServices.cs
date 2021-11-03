using AutoMapper;
using OnionWebApi.BL.Dtos;
using OnionWebApi.Models.Contexts;
using OnionWebApi.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionWebApi.Services.Services
{

	public interface ILoanServices : IBaseService<Loans, LoanDto> { }
	public class LoanServices: BaseServices<Loans, LoanDto>, ILoanServices
	{
        private readonly IPayServices payServices;
		public  LoanServices(BaseContext baseContext, IMapper mapper) : base(baseContext, mapper)
		{
            payServices = new PayServices(baseContext, mapper);
		}

        public  async override Task<LoanDto> Update(LoanDto dto)
        {
            var entityExist = Query().Any(x => x.Id == dto.Id);
            if (entityExist is false) return null;

            var entity = _mapper.Map<Loans>(dto);


            _dbSet.Update(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }
        private async Task createPay(Loans loans)
        {
            var Date = loans.StartDate;
            for(int CiclePayment= 1; CiclePayment <= loans.PaymentMount; CiclePayment++)
            {
                PayDto pay = new PayDto();
                //pay.mo
            }
        }
        




    }
}
