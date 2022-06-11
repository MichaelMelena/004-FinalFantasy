using FFXIV.Models.Quests;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.Quests;

public class QuestParser : IQuestParser
{
	public Quest ParseQuest(HtmlNode questEntry)
	{
		ArgumentNullException.ThrowIfNull(questEntry);

		string urlString = questEntry.SelectSingleNode("//div[1]").GetAttributeValue<string>("href", string.Empty);
		Uri uri = new Uri(urlString);

		//url x path /html/body/div[3]/div[2]/div[1]/div/div[3]/div[3]/div[2]/ul[2]/li[1]/div
		// "//div[class='entry__quest__name']/p"
		string name = questEntry.SelectSingleNode("//div[class='entry__quest__name']/p").InnerText;

		//"//div[class='entry__quest__name']/p/time/span"
		string dateString = questEntry.SelectSingleNode("//div[class='entry__quest__name']/p/time/span").InnerText;
		DateOnly date = DateOnly.Parse(dateString);
		Quest quest = new Quest(name, date, uri);

		return quest;
	}

	public QuestPage ParseQuestPage(HtmlNode html)
	{
		ArgumentNullException.ThrowIfNull(html);

		string xPathQuests = "//*[@id='anchor_quest']/div[3]/div[2]/ul[2]";
		string xPathPager = "//*[@id='anchor_quest']/div[3]/div[2]/ul[1]";

		List<Quest> quests = new List<Quest>();

		HtmlNode? node = html.SelectSingleNode(xPathPager);
		HtmlNode pagerLink = node.ReturnNotNullOrThrow(xPathPager);

		string? url = pagerLink.GetAttributeValue<string?>("href", null);

		Uri? nextPageUri = url is not null ? new Uri(url) : null;

		List<HtmlNode> questNodes = html.SelectSingleNode(xPathQuests).ChildNodes.ToList();

		foreach (HtmlNode questNode in questNodes)
		{
			Quest quest = ParseQuest(questNode);
			quests.Add(quest);
		}

		return new QuestPage(quests, nextPageUri);

	}
}
