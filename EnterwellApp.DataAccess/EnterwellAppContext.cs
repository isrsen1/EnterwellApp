using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EnterwellApp.BusinessLogic.Domain;

namespace EnterwellApp.DataAccess
{
    public class EnterwellAppContext: DbContext
    {
        public EnterwellAppContext()
            : base("name=EnterwellAppConnection")
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
    }
}
