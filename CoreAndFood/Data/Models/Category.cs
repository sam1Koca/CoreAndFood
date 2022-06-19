using System.Collections.Generic;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public List<Food> Foods { get; set; } // Bir Kategori içerisinde, birden fazla food barındırabilir.

    }
}
