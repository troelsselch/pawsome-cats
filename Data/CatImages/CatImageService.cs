using PawsomeCats.Data.CatFacts;
using System.Text.Json;

namespace PawsomeCats.Data.CatImages;

public class CatImageService
{
    private string url = "https://api.thecatapi.com/v1/images/search";

    public async Task<IEnumerable<CatImage>> GetCatImageAsync()
    {
        HttpClient client = new HttpClient();

        using HttpResponseMessage response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();

        IEnumerable<CatImage> catImages = JsonSerializer.Deserialize<IEnumerable<CatImage>>(await response.Content.ReadAsStringAsync())!;

        return catImages;
    }
}
