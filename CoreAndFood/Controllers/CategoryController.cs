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
            // Validation'a takılınca CategoryAdd Page'e tekrar yüklendir
            if (!ModelState.IsValid) { 
                
                return View("CategoryAdd");
            }

            categoryRepository.TAdd(category);

            return RedirectToAction("Index");
        }
    }
}
