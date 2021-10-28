using System.Collections.Generic;

namespace KetoBlog.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Posting> Postings { get; set; }

        public IEnumerable<Recipe> Recipes { get; set; }

        public IEnumerable<Food> Foods { get; set; }
    }
}
