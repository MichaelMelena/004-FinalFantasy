namespace FFXIV.Models.Quests;

public class QuestPage
{
	public QuestPage(List<Quest> quests, Uri? next)
	{
		Quests = quests;
		Next = next;
	}

	public List<Quest> Quests { get; } = new List<Quest>();

	public Uri? Next { get; }
}
