using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterwellApp.BusinessLogic.Domain;

namespace EnterwellApp.BusinessLogic.Repositories
{
    public interface IProductRepository: IRepository<Product>
    {
        IEnumerable<Product> getProductByUserId(string userId);
    }
}
