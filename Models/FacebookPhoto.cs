using Newtonsoft.Json;

namespace te3rafo.Models
{
    public class FacebookPhoto
    {
        [JsonProperty("picture")] // This renames the property to picture.
        public string ThumbnailUrl { get; set; }

        public string Link { get; set; }
    }
}
