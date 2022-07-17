using AnimeFacts.Abstractions.Queries.GetAllAnimes.Responses;
using Newtonsoft.Json.Linq;

namespace AnimeFacts.API.Requests.Queries.GetAllAnimes;

public static class AnimeFactsApiAdapter
{
    public static GetAllAnimesResponse Adapt(JObject jobject)
    {
        var data = jobject.SelectToken("data");

        if (data == null)
        {
            throw new Exception("Data property was not found.");
        }

        return new GetAllAnimesResponse
        {
            Animes = data.Select(x => new GetAllAnimesResponse.Anime { Name = x.SelectToken("anime_name")?.ToString() ?? string.Empty }).ToList()
        };
    }
}
