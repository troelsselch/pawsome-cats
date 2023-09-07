using System.Text.Json;

namespace PawsomeCats.Data.CatFacts;

public class CatFactService
{
    private string url = "https://cat-fact.herokuapp.com/facts";

    public async Task<IEnumerable<CatFact>> GetFactsAsync()
    {
        HttpClient client = new HttpClient();

        using HttpResponseMessage response = await client.GetAsync(url);

        response.EnsureSuccessStatusCode();

        IEnumerable<CatFact> catFacts = JsonSerializer.Deserialize<IEnumerable<CatFact>>(await response.Content.ReadAsStringAsync())!;

        return catFacts;
    }
}
