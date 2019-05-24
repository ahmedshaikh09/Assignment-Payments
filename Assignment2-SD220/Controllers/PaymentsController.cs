using Assignment2_SD220.Models;
using Assignment2_SD220.Models.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_SD220.Controllers
{
    [RoutePrefix("api/payment")]
    public class PaymentsController : ApiController
    {
        private ApplicationDbContext Context;

        public PaymentsController()
        {
            Context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Create(PaymentBindingModel formData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var brand = Context.CreditCards.FirstOrDefault(p => p.IdentificationNumber == formData.BrandId);

            if (brand == null)
            {
                ModelState.AddModelError("Incorrect Brand ID", "Brand Id provided does not exist");
                return BadRequest(ModelState);
            }

            if (formData.SecurityCode.Length > 4)
            {
                ModelState.AddModelError("Security Code Error", "Security Code can't be more than 4 digits");
                return BadRequest(ModelState);
            }

            if (formData.SecurityCode.Length < 3)
            {
                ModelState.AddModelError("Security Code Error", "Security Code can't be less than 3 digits");
                return BadRequest(ModelState);
            }

            if (formData.Amount <= 0)
            {
                ModelState.AddModelError("Amount Error", "The amount the system will charge the credit card. Needs to be greaterthan 0.");
                return BadRequest(ModelState);
            }

            var payment = Mapper.Map<Payment>(formData);

            Context.Payments.Add(payment);
            payment.CreditCard = brand;
            payment.PaymentSuccess = true;

            Context.SaveChanges();

            var model = Mapper.Map<PaymentViewModel>(payment);

            return Ok(model);
        }
    }
}
