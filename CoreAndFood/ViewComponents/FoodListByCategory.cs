using CoreAndFood.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoreAndFood.ViewComponents
{
    public class FoodListByCategory:ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            id = 1;
            FoodRepository foodRepository = new FoodRepository();
            var foodList = foodRepository.List(x => x.CategoryID == id);

            return View(foodList);
        }


    }
}
