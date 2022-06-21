using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository(); // Global Object

        public IActionResult Index()
        {
            return View(foodRepository.TList("Category"));
        }

        [HttpGet]
        public IActionResult AddFood()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            foodRepository.TAdd(food);
            return RedirectToAction("Index");
        }
    }
}
