using FinalFantasy.XIV.API.Models.Search;
using Refit;

namespace FinalFantasy.XIV.API.Services.Search;

public interface ISearchApi
{
	[Post("/search")]
	Task<SearchResponse<TResponse>> SearchAsync<TResponse, TRequest>([Body] SearchRequest<TRequest> body, [Query][AliasAs("private_key")] string? apiKey = null)
		where TResponse : class
		where TRequest : class, new();
}
