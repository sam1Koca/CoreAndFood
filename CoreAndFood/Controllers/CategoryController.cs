using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;
using CoreAndFood.Data.Models;

namespace CoreAndFood.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository(); // CategoryRepository Classına ulaşmam gerek. (GlobalObject)

        public IActionResult Index()
        {
            return View(categoryRepository.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            // Validation'a takılınca CategoryAdd Page'e tekrar yönlendir
            if (!ModelState.IsValid)
            {

                return View("CategoryAdd");
            }

            categoryRepository.TAdd(category);

            return RedirectToAction("Index");
        }

        public IActionResult CategoryGet(int id)
        {
            var item = categoryRepository.TGet(id);

            Category category = new Category()
            {
                CategoryName = item.CategoryName,
                CategoryDescription = item.CategoryDescription,
                CategoryID = item.CategoryID
            };

            return View(category);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category category)
        {
            var value = categoryRepository.TGet(category.CategoryID);

            value.CategoryName = category.CategoryName;
            value.CategoryDescription = category.CategoryDescription;
            value.Status = true;
            categoryRepository.TUpdate(value);

            return RedirectToAction("Index");
        }

        public IActionResult CategoryDelete(int id)
        {
            var currentStatus = categoryRepository.TGet(id);
            currentStatus.Status = false;

            categoryRepository.TUpdate(currentStatus);

            return RedirectToAction("Index");

        }
    }
}
