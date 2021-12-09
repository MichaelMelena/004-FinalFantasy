using FFXIV.Models.Quests;
using HtmlAgilityPack;

namespace FFXIV.Services.Parsers.Quests;

public interface IQuestParser
{
	Quest ParseQuest(HtmlNode html);

	QuestPage ParseQuestPage(HtmlNode html);
}
