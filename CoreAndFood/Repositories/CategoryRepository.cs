using CoreAndFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Repositories
{
    public class CategoryRepository  // Temel CRUD İşlemlerini Artık Repositoryler üzerinden yapacağız.
    {
        Context context = new Context();

        

        public List<Category> CategoryList() {

            return context.Categories.ToList();

        }

        public void CategoryAdd(Category category) {

            context.Categories.Add(category);
            context.SaveChanges();
        
        }

        public void CategoryDelete(Category category) {
            
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public void CategoryUpdate(Category category) { 

            context.Categories.Update(category);
            context.SaveChanges();
        }

        public void GetCategory(int id) {

            context.Categories.Find(id);
        }


    }
}
