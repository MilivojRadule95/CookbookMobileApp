using Newtonsoft.Json;
using System.Collections.Generic;

namespace CookbookXF.Models
{
    public class RecipeList
    {
        [JsonProperty("recipe")]
        public List<Recipe> Recipe { get; set; }
    }
}
