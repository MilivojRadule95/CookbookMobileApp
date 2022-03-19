using Newtonsoft.Json;
using System.Collections.Generic;

namespace CookbookXF.Models
{
    public class Root
    {
        [JsonProperty("recipe")]
        public List<Recipe> Recipe { get; set; }
    }
}
