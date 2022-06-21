using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category Name cannot be Left blank")]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<Food> Foods { get; set; } // Bir Kategori içerisinde, birden fazla food barındırabilir.

    }
}
