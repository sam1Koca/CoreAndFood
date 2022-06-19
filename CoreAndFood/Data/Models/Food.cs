namespace CoreAndFood.Data.Models
{
    public class Food
    {
        public int FoodID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; } // Kısa Açıklaması [Vitrin Tarafında Gözükecek Bu Açıklama]
        public string LongDescription { get; set; } // Uzun Açıklama [Detay Kısmında Gözükecek Bu Açıklama]
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public string ThumbNailImageUrl { get; set; } // Büyük halinin öncesindeki küçük halini tutacak
        public int Stock { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}
