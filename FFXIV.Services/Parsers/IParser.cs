using HtmlAgilityPack;

namespace FFXIV.Services.Parsers;

public interface IParser<T>
{
	T Parse(HtmlNode htmlNode);
}

