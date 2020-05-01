using Newtonsoft.Json;

namespace BachelorproefBlazor.Models
{
    public class Camera
    {
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string VolledigeNaam { get; set; }
    }
}
