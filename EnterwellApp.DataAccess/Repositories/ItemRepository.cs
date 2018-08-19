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
    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(EnterwellAppContext context) 
            : base(context)
        {
        }

        public EnterwellAppContext EnterwellAppContext
        {
            get { return Context as EnterwellAppContext; }
        }
    }
}
