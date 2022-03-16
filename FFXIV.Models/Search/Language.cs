using System.ComponentModel;

namespace FFXIV.Models.Search;

public enum Language
{
	[Description("ja")]
	Japanese = 0,
	[Description("en")]
	English = 1,
	[Description("de")]
	German = 2,
	[Description("fr")]
	French = 3
}
