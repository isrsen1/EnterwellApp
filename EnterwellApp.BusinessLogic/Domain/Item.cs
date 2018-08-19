using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterwellApp.BusinessLogic.Domain
{
    public class Item
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public double TotalPriceNoTax { get; set; }
        public string Description { get; set; }
    }
}
