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

        public IActionResult Statistics()
        {
            Context context = new Context();

            // Toplam Yemek Sayısı
            var value1 = context.Foods.Count();
            ViewBag.val1 = value1;


            // Toplam Kategori Sayısı
            var value2 = context.Categories.Count();
            ViewBag.val2 = value2;


            // Meyve Kategorisinde Kaç tane ürün var
            var foodİd = context.Categories.Where(x => x.CategoryName == "Fruit").
                Select(y => y.CategoryID).
                FirstOrDefault();

            var value3 = context.Foods.Where(x => x.CategoryID == foodİd).Count();
            ViewBag.val3 = value3;


            //Sebze Kategorisinde kaç tane ürün var
            var value4 = context.Foods.Where(x => x.CategoryID == context.Categories.Where(z => z.CategoryName == "Vegetables").
                Select(y => y.CategoryID).
                FirstOrDefault()).Count();
            ViewBag.val4 = value4;


            //Yemek Tablosunda Toplamda Kaç Ürün var (Her Yemeğin Stok Adedini topla)
            var value5 = context.Foods.Sum(x => x.Stock);
            ViewBag.val5 = value5;

            var value6 = context.Foods.Where(x => x.CategoryID == context.Categories.Where(y => y.CategoryName == "Legumes").Select(z => z.CategoryID)
            .FirstOrDefault()).Count();
            ViewBag.val6 = value6;

            return View();
        }

        
        
    }
}
