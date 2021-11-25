namespace FFXIV.Models.Characters.Profiles;

public record class GrandCompanyInfo
{
	public GrandCompanyInfo(GrandCompany grandCompany, GrandCompanyRank rank)
	{
		GrandCompany = grandCompany;
		Rank = rank;
	}

	public GrandCompany GrandCompany { get; }

	public GrandCompanyRank Rank { get; }
}
