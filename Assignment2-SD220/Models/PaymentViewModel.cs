using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_SD220.Models
{
    public class PaymentViewModel
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string NameOnCard { get; set; }

        public int CreditCardNumber { get; set; }

        public string SecurityCode { get; set; }

        public string BrandId { get; set; }
    }
}