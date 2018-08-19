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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(EnterwellAppContext context) 
            : base(context)
        {
            
        }

        

        public IEnumerable<Product> getProductByUserId(string userId)
        {
            return EnterwellAppContext.Products.Where(c=>c.User == userId).ToList() ;
        }

        public EnterwellAppContext EnterwellAppContext
        {
            get { return Context as EnterwellAppContext; }
        }

        
    }
}
