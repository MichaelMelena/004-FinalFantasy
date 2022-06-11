using System.ComponentModel;

namespace FFXIV.Models.Search;

public enum DataCenter
{
	[Description("_dc_Elemental")]
	Elemental,

	[Description("_dc_Gaia")]
	Gaia,
	[Description("_dc_Mana")]
	Mana,

	[Description("_dc_Aether")]
	Aether,

	[Description("_dc_Primal")]
	Primal,

	[Description("_dc_Crystal")]
	Crystal,

	[Description("_dc_Chaos")]
	Chaos,

	[Description("_dc_Light")]
	Light,

	[Description("_dc_Materia")]
	Materia
}

