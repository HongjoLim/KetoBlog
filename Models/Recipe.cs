using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KetoBlog.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        public string Title { get; set; }

        public List<Food> Ingredients { get; set; }

        public string Description { get; set; }
    }

    public class Food
    {
        [Key]
        public int FoodId { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }
    }

    public class FoodCategory
    {
        [Key]
        public int CategoryId { get; set; }

        public string Name { get; set; }
    }
}
