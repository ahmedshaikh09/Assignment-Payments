using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment2_SD220.Models
{
    public class PaymentBindingModel
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string NameOnCard { get; set; }

        [Required]
        [CreditCard]
        public int CreditCardNumber { get; set; }

        [Required]
        public string SecurityCode { get; set; }

        [Required]
        public string BrandId { get; set; }
    }
}