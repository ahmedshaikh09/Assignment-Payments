using Assignment2_SD220.Models;
using Assignment2_SD220.Models.Domain;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_SD220.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Init()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CreditCard, CreditCardViewModel>().ReverseMap();
                cfg.CreateMap<Payment, PaymentViewModel>().ReverseMap();
                cfg.CreateMap<Payment, PaymentBindingModel>().ReverseMap();
            });
        }
    }
}