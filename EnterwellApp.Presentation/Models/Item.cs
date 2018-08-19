using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterwellApp.Presentation.Models
{
    public class ItemVM
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double TotalPriceNoTax { get; set; }
        public string Description { get; set; }
    }
}