using System.Text.Json.Serialization;

namespace PawsomeCats.Data.CatFacts;

public class CatFact
{
    [JsonPropertyName("_id")]
    public string Id {  get; set; }
    [JsonPropertyName("text")]
    public string Text { get; set; }
}
