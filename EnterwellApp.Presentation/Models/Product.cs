using EnterwellApp.BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnterwellApp.Presentation.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required field")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required field")]
        public double UnitPriceNoTax { get; set; }
        public string User { get; set; }
        public IList<Item> Items { get; set; }
    }
}