using CoreAndFood.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreAndFood.Controllers
{
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult VisualizeProductResult()
        {
            return Json(ProductList());
        }

        public List<Class1> ProductList()
        {
           List<Class1> productList = new List<Class1>();
            productList.Add(new Class1()
            {
                productName = "Computer",
                stock = 120
            });

            productList.Add(new Class1()
            {
                productName = "Keyboard",
                stock = 45
            });

            productList.Add(new Class1()
            {
                productName = "Mouse",
                stock = 220
            });

            return productList;
        }
    }
}
