using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterwellApp.BusinessLogic.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceCreationDate { get; set; }
        public DateTime InvoiceDueDate { get; set; }
        public double TotalPriceNoTax { get; set; }
        public double TotalPriceWithTax { get; set; }
        public string InvoiceCreator { get; set; }
        public string InvoiceRecipient { get; set; }
        public IList<Item> Items { get; set; }
    }
}
