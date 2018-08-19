using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterwellApp.DataAccess;
using EnterwellApp.DataAccess.Repositories;
using EnterwellApp.BusinessLogic.Domain;
using EnterwellApp.BusinessLogic.Repositories;
using EnterwellApp.BusinessLogic;
using EnterwellApp.Presentation.Models;
using Microsoft.AspNet.Identity;

namespace EnterwellApp.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ActionResult Index()
        {
            

            if (User.Identity.IsAuthenticated)
            {
                string currentUserId = User.Identity.GetUserId();
                List<Product> products = _unitOfWork.Products.getProductByUserId(currentUserId).ToList();
                ViewBag.Proizvodi = products;
            }
            return View();
        }

       

        public ActionResult Products()
        {
            List <Product> products = _unitOfWork.Products.GetAll().ToList();
            List<ProductVM> productsVM = new List<ProductVM>();
            AutoMapper.Mapper.Map(products, productsVM);
            MyViewModel viewModel = new MyViewModel();
            viewModel.Products = productsVM;
            return View(viewModel);
        }

        
    }
}