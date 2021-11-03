using OnionWebApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnionWebApi.Models.Entities
{
    public class Loans:BaseEntity
    {
    
        public DateTime StartDate { get; set; }
        public double Amount { get; set; }
        public int PaymentMount { get; set; }
        public Term Term { get;set; }
        public Status Status { get; set; }
        public int DebtorId { get; set; }
        public int CreditorId { get; set; }

        [ForeignKey("DebtorId")]
        public virtual  User Debtor { get; set; }

        [ForeignKey("CreditorId")]
        public virtual User Creditor { get; set; }
        public virtual ICollection<PayL> PayLoansEntity { get; set; }

    }
}
