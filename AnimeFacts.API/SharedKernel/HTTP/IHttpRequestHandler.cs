using AnimeFacts.API.SharedKernel.Interfaces;
using Newtonsoft.Json.Linq;

namespace AnimeFacts.API.SharedKernel.HTTP;

public interface IHttpRequestHandler : IService
{
    Task<JObject> GetJObjectAsync(string url);
}
