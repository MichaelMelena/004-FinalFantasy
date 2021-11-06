using FinalFantasy.XIV.API.Models.Search.Items;
using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class Achievement
{
	[JsonProperty("AchievementCategory")]
	public AchievementCategory? AchievementCategory { get; set; }

	[JsonProperty("AchievementCategoryTarget")]
	public string? AchievementCategoryTarget { get; set; }

	[JsonProperty("AchievementCategoryTargetID")]
	public int AchievementCategoryTargetID { get; set; }

	[JsonProperty("AchievementHideCondition")]
	public AchievementHideCondition? AchievementHideCondition { get; set; }

	[JsonProperty("AchievementHideConditionTarget")]
	public string? AchievementHideConditionTarget { get; set; }

	[JsonProperty("AchievementHideConditionTargetID")]
	public int AchievementHideConditionTargetID { get; set; }

	[JsonProperty("AchievementTarget")]
	public AchievementTarget? AchievementTarget { get; set; }

	[JsonProperty("AchievementTargetTarget")]
	public string? AchievementTargetTarget { get; set; }

	[JsonProperty("AchievementTargetTargetID")]
	public int AchievementTargetTargetID { get; set; }

	[JsonProperty("Data0")]
	public int Data0 { get; set; }

	[JsonProperty("Data1")]
	public int Data1 { get; set; }

	[JsonProperty("Data2")]
	public int Data2 { get; set; }

	[JsonProperty("Data3")]
	public int Data3 { get; set; }

	[JsonProperty("Data4")]
	public int Data4 { get; set; }

	[JsonProperty("Data5")]
	public int Data5 { get; set; }

	[JsonProperty("Data6")]
	public int Data6 { get; set; }

	[JsonProperty("Data7")]
	public int Data7 { get; set; }

	[JsonProperty("Description")]
	public string? Description { get; set; }

	[JsonProperty("Description_de")]
	public string? DescriptionDe { get; set; }

	[JsonProperty("Description_en")]
	public string? DescriptionEn { get; set; }

	[JsonProperty("Description_fr")]
	public string? DescriptionFr { get; set; }

	[JsonProperty("Description_ja")]
	public string? DescriptionJa { get; set; }

	[JsonProperty("GamePatch")]
	public GamePatch? GamePatch { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Icon")]
	public string? Icon { get; set; }

	[JsonProperty("IconHD")]
	public string? IconHD { get; set; }

	[JsonProperty("IconID")]
	public int IconID { get; set; }

	[JsonProperty("Item")]
	public Item? Item { get; set; }

	[JsonProperty("ItemTarget")]
	public string? ItemTarget { get; set; }

	[JsonProperty("ItemTargetID")]
	public int ItemTargetID { get; set; }

	[JsonProperty("Key")]
	public int Key { get; set; }

	[JsonProperty("Name")]
	public string? Name { get; set; }

	[JsonProperty("NameCombined")]
	public string? NameCombined { get; set; }

	[JsonProperty("NameCombined_cn")]
	public string? NameCombinedCn { get; set; }

	[JsonProperty("NameCombined_de")]
	public string? NameCombinedDe { get; set; }

	[JsonProperty("NameCombined_en")]
	public string? NameCombinedEn { get; set; }

	[JsonProperty("NameCombined_fr")]
	public string? NameCombinedFr { get; set; }

	[JsonProperty("NameCombined_ja")]
	public string? NameCombinedJa { get; set; }

	[JsonProperty("NameCombined_kr")]
	public string? NameCombinedKr { get; set; }

	[JsonProperty("NameLocale")]
	public string? NameLocale { get; set; }

	[JsonProperty("Name_de")]
	public string? NameDe { get; set; }

	[JsonProperty("Name_en")]
	public string? NameEn { get; set; }

	[JsonProperty("Name_fr")]
	public string? NameFr { get; set; }

	[JsonProperty("Name_ja")]
	public string? NameJa { get; set; }

	[JsonProperty("Order")]
	public int Order { get; set; }

	[JsonProperty("Patch")]
	public int Patch { get; set; }

	[JsonProperty("Points")]
	public int Points { get; set; }

	[JsonProperty("QuestRequirementsAll")]
	public bool QuestRequirementsAll { get; set; }

	[JsonProperty("Title")]
	public Title? Title { get; set; }

	[JsonProperty("TitleTarget")]
	public string? TitleTarget { get; set; }

	[JsonProperty("TitleTargetID")]
	public int TitleTargetID { get; set; }

	[JsonProperty("Type")]
	public int Type { get; set; }

	[JsonProperty("Url")]
	public string? Url { get; set; }

	[JsonProperty("UrlType")]
	public string? UrlType { get; set; }

	[JsonProperty("_")]
	public string? Index { get; set; }

	[JsonProperty("_Score")]
	public int Score { get; set; }
}

