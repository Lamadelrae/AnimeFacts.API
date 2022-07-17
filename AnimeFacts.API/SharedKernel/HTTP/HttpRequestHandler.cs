using Newtonsoft.Json.Linq;

namespace AnimeFacts.API.SharedKernel.HTTP;

public class HttpRequestHandler : IHttpRequestHandler
{
    readonly HttpClient _client = new HttpClient();

    public async Task<JObject> GetJObjectAsync(string url)
    {
        var response = await _client.GetAsync(url);

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception("Request was not able to execute.");
        }

        var jObject = JObject.Parse(await response.Content.ReadAsStringAsync());

        if (jObject == null)
        {
            throw new Exception("Object serializtion was not possible.");
        }

        return jObject;
    }
}
