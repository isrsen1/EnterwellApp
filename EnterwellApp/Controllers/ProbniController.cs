using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterwellApp.Business.Interface;
using EnterwellApp.Business;
using EnterwellApp.Domain;
using EnterwellApp.Repository;


namespace EnterwellApp.Controllers
{
    public class ProbniController : Controller
    {
        IProizvod _proizvod;
        public ProbniController(IProizvod proizvod)
        {
            _proizvod = proizvod;
        }
        // GET: Probni
        public ActionResult Index()
        {
            List<ProizvodDomainModel> proizvodi = new List<ProizvodDomainModel>();
            proizvodi = _proizvod.DohvatiProizvode();
            List<ProizvodViewModel> proizvodiView = new List<ProizvodViewModel>();
            AutoMapper.Mapper.Map(proizvodi, proizvodiView);
            ViewBag.ListaProizvoda = proizvodiView;
            return View();
        }
    }
}