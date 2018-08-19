using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterwellApp.BusinessLogic.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double UnitPriceNoTax { get; set; }
        public string User { get; set; }
        public IList<Item> Items { get; set; }
    }
}
