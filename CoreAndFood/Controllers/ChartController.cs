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


            // Baklagillerden Kaç Ürün Var
            var value6 = context.Foods.Where(x => x.CategoryID == context.Categories.Where(y => y.CategoryName == "Legumes").Select(z => z.CategoryID)
            .FirstOrDefault()).Count();
            ViewBag.val6 = value6;


            // Food Tablosunda Stok Adedi En Fazla Olan Ürünü Getir.
            var value7 = context.Foods.OrderByDescending(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.val7 = value7;


            // Food Tablosunda stok adedi en az olan Ürünü getir.
            var value8 = context.Foods.OrderBy(x => x.Stock).Select(y => y.Name).FirstOrDefault();
            ViewBag.val8 = value8;


            // Foodların ortalama satış fiyatı
            var value9 = context.Foods.Average(x => x.Price).ToString("0.00"); // Formatlama işlemi / değer 0.00 şeklinde gözüksün
            ViewBag.val9 = value9;


            // Bir Kategorinin İçinde Bulunan Toplam Ürün/meyve Sayısı : Fruit
            var value10 = context.Categories.Where(x => x.CategoryName == "Fruit").Select(y => y.CategoryID).FirstOrDefault();
            var deger10Plus = context.Foods.Where(y => y.CategoryID == value10).Sum(x => x.Stock);
            ViewBag.val10 = deger10Plus;


            // Bir Kategorinin İçinde Bulunan Toplam Ürün/meyve Sayısı : Vegetables
            var value11 = context.Categories.Where(x => x.CategoryName == "Vegetables").Select(y => y.CategoryID).FirstOrDefault();
            var deger11Plus = context.Foods.Where(y => y.CategoryID == value11).Sum(x => x.Stock);
            ViewBag.val11 = deger11Plus;

            var value12 = context.Foods.OrderByDescending(x => x.Price).Select(y => y.Name).FirstOrDefault();
            ViewBag.val12 = value12;

            return View();


        }

        
        
    }
}
