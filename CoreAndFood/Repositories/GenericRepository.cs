using CoreAndFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CoreAndFood.Repositories
{
    public class GenericRepository<T> where T : class,new()
    {
        Context context = new Context();


        public List<T> TList()
        {
            return context.Set<T>().ToList();
        }

        public void TAdd(T parameter)
        {
            context.Set<T>().Add(parameter);
            context.SaveChanges();
        }

        public void TDelete(T parameter)
        {
            context.Set<T>().Remove(parameter);
            context.SaveChanges();
        }

        public void TUpdate(T parameter)
        {
            context.Set<T>().Update(parameter);
            context.SaveChanges();
        }

        public void TGet(int id)
        {
            context.Set<T>().Find(id);
        }
    }
}
