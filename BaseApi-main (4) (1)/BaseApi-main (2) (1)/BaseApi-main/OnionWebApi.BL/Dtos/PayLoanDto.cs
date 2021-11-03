using OnionWebApi.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
namespace OnionWebApi.BL.Dtos
{
    public class PayLoanDto : BaseDto 
    {
        public int PayId { get; set; }
        public int LoansId { get; set; }
    }
}
