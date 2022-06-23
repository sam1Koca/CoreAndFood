using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using X.PagedList;

namespace CoreAndFood.Controllers
{
    public class FoodController : Controller
    {
        FoodRepository foodRepository = new FoodRepository(); // Global Object
        Context context = new Context();

        public IActionResult Index(int page = 1)
        {
            return View(foodRepository.TList("Category").ToPagedList(page, 3));
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

            var food = context.Foods.Find(id);
            foodRepository.TDelete(food); // Bir diğer yöntemde burada Food'u newleyip, FoodID ye; gelen id paremetresini atarak silebilirim
            return RedirectToAction("Index");
        }

        public IActionResult FoodGet(int id)
        {
            var x = foodRepository.TGet(id);

            List<SelectListItem> selectLists = (from items in context.Categories.ToList()
                                                select new SelectListItem
                                                {
                                                    Text = items.CategoryName,
                                                    Value = items.CategoryID.ToString()

                                                }).ToList();
            ViewBag.value = selectLists;

            Food food = new Food()
            {
                FoodID = x.FoodID,
                CategoryID = x.CategoryID,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock,
                Description = x.Description,
                ImageURL = x.ImageURL
            };

            return View(food);
        }

        [HttpPost]
        public IActionResult FoodUpdate(Food food)
        {
            var x = foodRepository.TGet(food.FoodID);
            x.Name = food.Name;
            x.Stock = food.Stock;
            x.Description = food.Description;
            x.ImageURL = food.ImageURL;
            x.Price = food.Price;
            x.CategoryID = food.CategoryID;

            foodRepository.TUpdate(x);

            return RedirectToAction("Index");
        }

    }
}
