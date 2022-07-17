using AnimeFacts.Abstractions.Queries.GetAllAnimes.Requests;
using AnimeFacts.Abstractions.Queries.GetAllAnimes.Responses;
using AnimeFacts.API.SharedKernel.HTTP;
using MediatR;

namespace AnimeFacts.API.Requests.Queries.GetAllAnimes;

public class GetAllAnimesHandler : IRequestHandler<GetAllAnimesRequest, GetAllAnimesResponse>
{
    private readonly IHttpRequestHandler _httpRequestHandler;

    public GetAllAnimesHandler(IHttpRequestHandler httpRequestHandler)
        => _httpRequestHandler = httpRequestHandler;

    public async Task<GetAllAnimesResponse> Handle(GetAllAnimesRequest request, CancellationToken cancellationToken)
    {
        return AnimeFactsApiAdapter.Adapt(await _httpRequestHandler.GetJObjectAsync("https://anime-facts-rest-api.herokuapp.com/api/v1"));
    }
}
