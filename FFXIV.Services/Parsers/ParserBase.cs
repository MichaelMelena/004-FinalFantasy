using System.Diagnostics.CodeAnalysis;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers;

public abstract class ParserBase
{
	/// <summary>
	/// Makes null check and returns not null HtmlNode or throws Exception
	/// </summary>
	/// <param name="htmlNode">HAP HTML Node</param>
	/// <param name="xPath">HAP select expression</param>
	/// <returns></returns>
	/// <exception cref="InvalidOperationException">When HTML Node is not found for specified xPath</exception>
	protected HtmlNode ReturnNotNullOrThrow([MaybeNull] HtmlNode? htmlNode, [NotNull] string xPath)
	{
		ArgumentNullException.ThrowIfNull(htmlNode);
		ArgumentNullException.ThrowIfNull(xPath);

		if (htmlNode is null)
		{
			throw new InvalidOperationException(string.Format(Resource.HtmlNodeNotFound, xPath));
		}

		return htmlNode;
	}
}
