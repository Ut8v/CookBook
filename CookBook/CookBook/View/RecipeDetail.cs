using System.Collections.Generic;

namespace CookBook.Model
{
    public class RecipeDetail
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Instructions { get; set; }
    }
}
