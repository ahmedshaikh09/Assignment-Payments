using Assignment2_SD220.Models;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_SD220.Controllers
{
    [RoutePrefix("api/credit-card")]
    public class CreditCardsController : ApiController
    {
        private ApplicationDbContext Context;

        public CreditCardsController()
        {
            Context = new ApplicationDbContext();
        }

        [Route("get-all")]
        public IHttpActionResult GetAll()
        {
            var model = Context
                 .CreditCards
                 .ProjectTo<CreditCardViewModel>()
                 .ToList();

            return Ok(model);
        }
    }
}
