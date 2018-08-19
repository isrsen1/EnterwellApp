using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterwellApp.BusinessLogic.Domain;
using EnterwellApp.BusinessLogic.Repositories;
using EnterwellApp.BusinessLogic;
using EnterwellApp.DataAccess.Repositories;

namespace EnterwellApp.DataAccess
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly EnterwellAppContext _context;

        public UnitOfWork(EnterwellAppContext context)
        {
            _context = context;
            Invoices = new InvoiceRepository(_context);
            Items = new ItemRepository(_context);
            Products = new ProductRepository(_context);
        }

        public IInvoiceRepository Invoices { get; private set; }
        public IItemRepository Items { get; private set; }
        public IProductRepository Products { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
