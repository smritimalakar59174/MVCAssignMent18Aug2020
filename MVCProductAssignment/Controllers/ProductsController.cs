using MVCProductAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProductAssignment.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var product = GetProduct();
            return View(product);
        }
        private IEnumerable<Products> GetProduct()
        {
            return new List<Products>
            {
                new Products {ProductId = 101 , ProductName = "AC", ProductRate=45000},
                new Products {ProductId = 102 , ProductName = "Mobile", ProductRate=38000},
                new Products {ProductId = 103 , ProductName = "Bike", ProductRate=94000},
            };
        }
        public ActionResult Details(int id)
        {
            var proDetail = GetProduct().SingleOrDefault(c => c.ProductId == id);
            if (proDetail == null)
            {
                return HttpNotFound();

            }
            return View(proDetail);
        }
    }
}