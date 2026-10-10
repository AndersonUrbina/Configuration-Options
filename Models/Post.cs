using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Configuration_Options.Models
{
    public class Post
    {
        public int Id { get; set; }

        [JsonPropertyName("title")]
        [Required] public string title { get; set; }
        [Required] public string Body { get; set; }
        [Required] public string Author { get; set; }
        public DateTime CreatedUtc { get; set; } = DateTime.UtcNow;

    }
}
