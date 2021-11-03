using OnionWebApi.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionWebApi.BL.Dtos
{
    public class PayDto: BaseDto
    {
        public string Voucher { get; set; }
        public double Mount { get; set; }
        public DateTime RealizationDate { get; set; }
        public DateTime Rstablished { get; set; }
        public virtual ICollection<PayLoanDto> PayLoansEntity { get; set; }
    }
}
