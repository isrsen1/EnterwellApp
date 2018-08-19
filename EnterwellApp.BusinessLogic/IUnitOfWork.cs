using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterwellApp.BusinessLogic.Repositories;

namespace EnterwellApp.BusinessLogic
{
    public interface IUnitOfWork: IDisposable
    {
        IInvoiceRepository Invoices { get; }
        IItemRepository Items { get; }
        IProductRepository Products { get; }
        int Complete();
    }
}
