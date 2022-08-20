using FFXIV.Services.Parsers;
using HtmlAgilityPack;
using Refit;

namespace FFXIV.Services.Resolvers;

public class ResolverService<T>
{
	private readonly IParser<T> parser;

	public ResolverService(IParser<T> parser)
	{
		this.parser = parser;
	}

	public async Task<T> ResolveAsync(ApiResponse<string> apiResponse)
	{
		await apiResponse.EnsureSuccessStatusCodeAsync();
		HtmlDocument htmlDocument = new HtmlDocument();
		htmlDocument.LoadHtml(apiResponse.Content);
		return parser.Parse(htmlDocument.DocumentNode);
	}
}

