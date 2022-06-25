using CoreAndFood.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoreAndFood.Data;
using CoreAndFood.Data.Models;
using System.Linq;

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

        public IActionResult Index3()
        {
            return View();
        }
        public List<Class2> FoodList()
        {
            List<Class2> class2 = new List<Class2>();
            using(var context = new Context())
            {
                class2 = context.Foods.Select(x => new Class2() { foodName = x.Name, stock = x.Stock }).ToList();
                return class2;
            }
        }

        public IActionResult VisualizeProductResult2()
        {
            return Json(FoodList());
        }

        
        
    }
}
