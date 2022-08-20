using System.Diagnostics.CodeAnalysis;

namespace FFXIV.Models.Characters.Profiles;

public record class CharacterProfile
{
	private string? _name = "your name";
	[NotNull]
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

	private GrandCompanyInfo? grandCompanyInfo;
	public GrandCompanyInfo GrandCompanyInfo
	{
		get => grandCompanyInfo!;
		set
		{
			ArgumentNullException.ThrowIfNull(value);
			grandCompanyInfo = value;
		}
	}


	private string? _nameDay = "long long time ago!";
	[NotNull]
	public string NameDay
	{
		get { return _nameDay!; }
		set
		{
			ArgumentNullException.ThrowIfNull(_nameDay);
			_nameDay = value;
		}
	}



	private string? server = "new server. who this?";
	[NotNull]
	public string Server
	{
		get => server!;
		set
		{
			ArgumentNullException.ThrowIfNull(value);
			server = value;
		}
	}

}
