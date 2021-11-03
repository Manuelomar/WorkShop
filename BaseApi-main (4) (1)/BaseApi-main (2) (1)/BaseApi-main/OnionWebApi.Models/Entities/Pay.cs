using System;
using System.Collections.Generic;
using System.Text;

namespace OnionWebApi.Models.Entities
{
    public class Pay:BaseEntity
    {
        public string Voucher { get; set; }
        public double Mount { get; set; }

        public DateTime RealizationDate { get; set; }
        public DateTime Rstablished { get; set; }
        public virtual ICollection<PayL> PayLoansEntity { get; set; }
    }
}
