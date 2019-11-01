using ProMvc5.ViewModel.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProMvc5.ViewModel.Controllers {
    public class SampleController : Controller {
        public ActionResult Index() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View();
        }

        public ActionResult Index2() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View("NotIndex");
        }

        public ActionResult Index3() {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            return View("~/Views/Example/Index.cshtml");
        }

        public ActionResult Message() {
            ViewBag.Message = "This is a partial view.";
            return PartialView();
        }

        public ActionResult Details()
        {
            var products = new List<ProMvc5.ViewModel.Models.Product>
            {
                new Product
                {
                    Title = "Shrimp",
                    Price = 22.32M
                },
                new Product
                {
                    Title = "Chili Powder",
                    Price = 12.23M
                },
                new Product
                {
                    Title = "Soy Milk",
                    Price = 3.35M
                }
            };
            

            ViewBag.Message = "This is a partial view.";
            return View(products);
        }

        public ActionResult PartialViewDemo() {
            return View();
        }
    }
}
