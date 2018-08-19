using EnterwellApp.BusinessLogic;
using EnterwellApp.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterwellApp.Presentation.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public InvoiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Invoice
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            InvoiceVM invoiceVM = new InvoiceVM();
            
            return View(invoiceVM);
        }
    }
}