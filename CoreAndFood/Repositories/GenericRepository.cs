using CoreAndFood.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public T TGet(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> TList(string parameter) //Food List alanında, categoryName göstermek için kullandık bu metodu.
        {
            return context.Set<T>().Include(parameter).ToList();        
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }
    }
}
