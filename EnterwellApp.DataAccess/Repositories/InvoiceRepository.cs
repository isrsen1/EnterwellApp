using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterwellApp.BusinessLogic.Domain;
using EnterwellApp.BusinessLogic.Repositories;

namespace EnterwellApp.DataAccess.Repositories
{
    public class InvoiceRepository : Repository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(EnterwellAppContext context) 
            : base(context)
        {
        }

        public string getSomething()
        {
            return "Nesto";
        }

        public EnterwellAppContext EnterwellAppContext
        {
            get { return Context as EnterwellAppContext; }
        }
    }
}
