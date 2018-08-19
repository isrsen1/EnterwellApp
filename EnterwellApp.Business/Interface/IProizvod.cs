using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterwellApp.Domain;

namespace EnterwellApp.Business.Interface
{
    public interface IProizvod
    {
        string DohvatiProizvod(int Id);
        List<ProizvodDomainModel> DohvatiProizvode();
        
    }
}
