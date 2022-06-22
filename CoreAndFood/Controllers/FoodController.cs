using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository(); // Global Object
        Context context = new Context();

        public IActionResult Index()
        {
            return View(foodRepository.TList("Category"));
        }


        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> selectLists = (from item in context.Categories.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = item.CategoryName,
                                                    Value = item.CategoryID.ToString()

                                                }).ToList();
            ViewBag.value = selectLists;
            return View();
        }

        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            foodRepository.TAdd(food);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteFood(int id) {

            var value = context.Foods.Find(id);
            foodRepository.TDelete(value); // Bir diğer yöntemde burada Food'u newleyip, FoodID ye; gelen id paremetresini atarak silebilirim
            return RedirectToAction("Index");
        }
    }
}
