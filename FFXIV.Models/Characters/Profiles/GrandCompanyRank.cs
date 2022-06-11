using System.ComponentModel;

namespace FFXIV.Models.Characters.Profiles;

public enum GrandCompanyRank
{
	[Description("")]
	NotInGrandCompany,

	[Description("Private Third Class")]
	PrivateThirdClass,

	[Description("Private Second Class")]
	PrivateSecondClass,

	[Description("Private First Class")]
	PrivateFirstClass,

	[Description("Corporal")]
	Corporal,

	[Description("Sergeant Third Class")]
	SergeantThirdClass,

	[Description("Sergeant Second Class")]
	SergeantSecondClass,

	[Description("Sergeant First Class")]
	SergeantFirstClass,

	[Description("Chief Sergeant")]
	ChiefSergeant,

	[Description("Second Lieutenant")]
	SecondLieutenant,

	[Description("First Lieutenant")]
	FirstLieutenant,

	[Description("Captain")]
	Captain
}
