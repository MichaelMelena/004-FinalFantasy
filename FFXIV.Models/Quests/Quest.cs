namespace FFXIV.Models.Quests;

public record class Quest
{
	public Quest(string name, DateOnly completedAt, Uri url)
	{
		Name = name;
		CompletedAt = completedAt;
		Url = url;
	}

	private string? name;
	public string Name
	{
		get => name!;
		set
		{
			ArgumentNullException.ThrowIfNull(value);
			name = value;
		}
	}

	public DateOnly CompletedAt { get; set; }

	private Uri? url;
	public Uri Url
	{
		get => url!;
		set
		{
			ArgumentNullException.ThrowIfNull(value);
			url = value;
		}
	}
}
