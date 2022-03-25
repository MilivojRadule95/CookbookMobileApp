using Newtonsoft.Json;

namespace CookbookXF.Models
{
    public class Step
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
