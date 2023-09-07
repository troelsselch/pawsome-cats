using System.Text.Json.Serialization;

namespace PawsomeCats.Data.CatImages;

public class CatImage
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("width")]
    public int Width { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
}
