using EnterwellApp.BusinessLogic.Domain;
using EnterwellApp.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterwellApp.Presentation.Infrastructure
{
    public class AutomapperWebProfile: AutoMapper.Profile
    {
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(
                a=> {
                    a.AddProfile<AutomapperWebProfile>();
                }
                );
        }
        public AutomapperWebProfile()
        {
            CreateMap<Product, ProductVM>();
            CreateMap<ProductVM, Product>();
            CreateMap<Invoice, InvoiceVM>();
            CreateMap<InvoiceVM, Invoice>();
            CreateMap<Item, ItemVM>();
            CreateMap<ItemVM, Item>();
        }
    }
}