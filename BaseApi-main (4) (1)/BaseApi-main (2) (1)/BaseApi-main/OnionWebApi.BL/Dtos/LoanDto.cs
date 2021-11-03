using OnionWebApi.Models.Enums;
using OnionWebApi.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionWebApi.BL.Dtos
{
   public  class LoanDto:BaseDto
    {
        public DateTime StartDate { get; set; }
        public double Amount { get; set; }
        public int PaymentMount { get; set; }
        public Term Term { get; set; }
        public Status Status { get; set; }
        public int DebtorId { get; set; }
        public int CreditorId { get; set; }
    }
}
