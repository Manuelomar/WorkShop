using System;
using System.Collections.Generic;
using System.Text;

namespace OnionWebApi.Models.Entities
{
   public class User:BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Loans> DebtorLoans { get; set; }
        public virtual ICollection<Loans> CreditorLoans { get; set; }
    }
}
