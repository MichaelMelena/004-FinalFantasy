using System.Diagnostics.CodeAnalysis;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers;

public static class ParserExtenstions
{
	/// <summary>
	/// Makes null check and returns not null HtmlNode or throws Exception
	/// </summary>
	/// <param name="htmlNode">HAP HTML Node</param>
	/// <param name="xPath">HAP select expression</param>
	/// <returns></returns>
	/// <exception cref="ArgumentException">When HTML Node is not found for specified xPath</exception>
	public static HtmlNode ReturnNotNullOrThrow([MaybeNull] this HtmlNode? htmlNode, [NotNull] string xPath)
	{
		ArgumentNullException.ThrowIfNull(htmlNode);
		ArgumentNullException.ThrowIfNull(xPath);

		if (htmlNode is null)
		{
			throw new ArgumentException(string.Format(Resource.HtmlNodeNotFound, xPath));
		}

		return htmlNode;
	}
}
