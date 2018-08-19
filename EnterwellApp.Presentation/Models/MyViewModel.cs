using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterwellApp.Presentation.Models
{
    public class MyViewModel
    {
        public List<ProductVM> Products { get; set; }
        public List<ItemVM> Items { get; set; }
        public List<InvoiceVM> Invoices { get; set; }
    }
}