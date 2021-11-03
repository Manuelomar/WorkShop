using System;
using System.Collections.Generic;
using System.Text;

namespace OnionWebApi.Models.Entities
{
    public class PayL : BaseEntity
    {
        public int PayId { get; set; }
        public int LoansId { get; set; }
    }
}
