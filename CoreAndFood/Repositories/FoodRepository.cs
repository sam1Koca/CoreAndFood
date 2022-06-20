using CoreAndFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Repositories
{
    public class FoodRepository
    {
        Context context = new Context();

        public void FoodAdd(Food food) {

            context.Foods.Add(food);
            context.SaveChanges();
        }

        public void FoodDelete(Food food)
        {

            context.Foods.Remove(food);
            context.SaveChanges();
        }

        public void FoodUpdate(Food food)
        {

            context.Foods.Update(food);
            context.SaveChanges();
        }

        public List<Food> FoodList(Food food)
        {

            return context.Foods.ToList();
        }

        public void GetFood(int id)
        {

            context.Foods.Find(id);
        }

    }
}
