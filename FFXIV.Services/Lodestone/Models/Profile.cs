namespace FFXIV.Services.Lodestone.Models;

public record class Profile
{
	public Profile(string name)
	{
		Name = name;
	}

	private string? _name;

	public string Name
	{
		get => _name!;
		set
		{
			ArgumentNullException.ThrowIfNull(value);
			_name = value;
		}
	}
}
