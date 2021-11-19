namespace FFXIV.Models.Characters.Profiles;

public record class Profile
{
	public Profile(
		string name,
		Race race,
		Clan clan,
		Gender gender,
		CityState cityState,
		GrandCompany grandCompany,
		string nameDay)
	{
		Name = name;
		Race = race;
		Clan = clan;
		Gender = gender;
		CityState = cityState;
		GrandCompany = grandCompany;
		NameDay = nameDay;
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

	public Race Race { get; set; }

	public Clan Clan { get; set; }

	public Gender Gender { get; set; }

	public CityState CityState { get; set; }

	public GrandCompany GrandCompany { get; set; }

	private string? _nameDay;
	public string NameDay
	{
		get { return _nameDay!; }
		set
		{
			ArgumentNullException.ThrowIfNull(_nameDay);
			_nameDay = value;
		}
	}

}
