using System.ComponentModel;

namespace FFXIV.Models.Characters.Profiles;

public enum GrandCompany
{
	[Description("Immortal Flames")]
	ImmortalFlames = 0,
	
	[Description("Maelstrom")]
	Maelstrom = 1,

	[Description("Order of the Twin Adder")]
	OrderOfTheTwinAdder = 2,

	[Description("No Affiliation")]
	NoAffiliation = 3
}
