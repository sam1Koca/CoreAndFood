using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category Name cannot be Left blank")]
        [StringLength(20, ErrorMessage = "Please only enter 5-20 characters", MinimumLength =5)]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public bool Status {get; set; }

        public List<Food> Foods { get; set; } // Bir Kategori içerisinde, birden fazla food barındırabilir.

        

    }
}
