using EnterwellApp.BusinessLogic;
using EnterwellApp.BusinessLogic.Domain;
using EnterwellApp.Presentation.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterwellApp.Presentation.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewAll()
        {
            if (User.Identity.IsAuthenticated) {
                string currentUserId = User.Identity.GetUserId();
                List<Product> products = _unitOfWork.Products.getProductByUserId(currentUserId).ToList();
                List<ProductVM> productsVM = new List<ProductVM>();
                AutoMapper.Mapper.Map(products, productsVM);

                return View(productsVM);
            }

            return View();
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            ProductVM productVM = new ProductVM();
            if(id != 0)
            {
                Product product = _unitOfWork.Products.Get(id);
                AutoMapper.Mapper.Map(product, productVM);
                
            }
            return View(productVM);
        }

        [HttpPost]
        public ActionResult AddOrEdit(ProductVM productVM)
        {
            if (productVM.Name != null)
            {
                Product product = new Product();
                if (productVM.Id == 0)
                {
                    productVM.User = User.Identity.GetUserId();
                    AutoMapper.Mapper.Map(productVM, product);
                    _unitOfWork.Products.Add(product);
                    _unitOfWork.Complete();
                }
                else
                {
                    AutoMapper.Mapper.Map(productVM, product);
                    productVM.User = User.Identity.GetUserId();
                    _unitOfWork.Complete();
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Product product = new Product();
            product = _unitOfWork.Products.Get(id);
            _unitOfWork.Products.Remove(product);
            _unitOfWork.Complete();

            return RedirectToAction("Index");
        }

        
    }
}