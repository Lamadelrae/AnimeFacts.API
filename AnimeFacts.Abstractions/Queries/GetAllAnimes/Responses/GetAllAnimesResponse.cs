namespace AnimeFacts.Abstractions.Queries.GetAllAnimes.Responses;

public class GetAllAnimesResponse
{
    public List<Anime> Animes { get; set; } = new List<Anime>();

    public class Anime
    {
        public string Name { get; set; } = string.Empty;
    }
}
