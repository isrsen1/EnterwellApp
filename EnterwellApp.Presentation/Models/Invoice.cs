using EnterwellApp.BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterwellApp.Presentation.Models
{
    public class InvoiceVM
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