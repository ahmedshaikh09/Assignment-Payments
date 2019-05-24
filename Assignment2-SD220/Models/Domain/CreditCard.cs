using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_SD220.Models.Domain
{
    public class CreditCard
    {
        public int Id { get; set; }

        public string IdentificationNumber { get; set; }

        public string Brand { get; set; }

        public virtual List<Payment> Payments { get; set; }

        public CreditCard()
        {
            Payments = new List<Payment>();
        }
    }
}