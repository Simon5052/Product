using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shop2.Models;

namespace shop2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Random()
        {
            var product = new Product();
            product.name = "Television";
            product.id = 3;

            return View(product);
        }
        public ActionResult Add()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Edit()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Details()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}