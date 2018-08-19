using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterwellApp.Business.Interface;
using EnterwellApp.Domain;

namespace EnterwellApp.Business
{
    public class ProizvodBusinessLayer : IProizvod
    {
        public ProizvodBusinessLayer()
        {

        }
       
        public string DohvatiProizvod(int Id)
        {
            return "Nesto " + Id;
        }

        public List<ProizvodDomainModel> DohvatiProizvode()
        {
            List<ProizvodDomainModel> Proizvodi = new List<ProizvodDomainModel>();
            Proizvodi.Add(new ProizvodDomainModel { Id = 1, Naziv = "NestoNesto" });
            Proizvodi.Add(new ProizvodDomainModel { Id = 2, Naziv = "Nesto2" });
            return Proizvodi;
        }
    }
}
