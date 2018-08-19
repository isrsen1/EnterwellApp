using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EnterwellApp.Repository
{
    public class MyContext: DbContext
    {
        public MyContext() : base("name=EnterwellDBConnection")
        {

        }

        DbSet<Korisnik> Korisnici { get; set; }
    }
}
