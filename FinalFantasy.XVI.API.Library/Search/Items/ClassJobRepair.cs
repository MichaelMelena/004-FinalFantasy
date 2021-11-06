using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Items;

public class ClassJobRepair
{
	[JsonProperty("Abbreviation")]
	public string? Abbreviation { get; set; }

	[JsonProperty("Abbreviation_de")]
	public string? AbbreviationDe { get; set; }

	[JsonProperty("Abbreviation_en")]
	public string? AbbreviationEn { get; set; }

	[JsonProperty("Abbreviation_fr")]
	public string? AbbreviationFr { get; set; }

	[JsonProperty("Abbreviation_ja")]
	public string? AbbreviationJa { get; set; }

	[JsonProperty("BattleClassIndex")]
	public string? BattleClassIndex { get; set; }

	[JsonProperty("CanQueueForDuty")]
	public int CanQueueForDuty { get; set; }

	[JsonProperty("ClassJobCategory")]
	public ClassJobCategory? ClassJobCategory { get; set; }

	[JsonProperty("ClassJobCategoryTarget")]
	public string? ClassJobCategoryTarget { get; set; }

	[JsonProperty("ClassJobCategoryTargetID")]
	public int ClassJobCategoryTargetID { get; set; }

	[JsonProperty("ClassJobParent")]
	public object? ClassJobParent { get; set; }

	[JsonProperty("ClassJobParentTarget")]
	public string? ClassJobParentTarget { get; set; }

	[JsonProperty("ClassJobParentTargetID")]
	public int ClassJobParentTargetID { get; set; }

	[JsonProperty("DohDolJobIndex")]
	public int DohDolJobIndex { get; set; }

	[JsonProperty("ExpArrayIndex")]
	public int ExpArrayIndex { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Icon")]
	public string? Icon { get; set; }

	[JsonProperty("IsLimitedJob")]
	public int IsLimitedJob { get; set; }

	[JsonProperty("ItemSoulCrystal")]
	public ItemSoulCrystal? ItemSoulCrystal { get; set; }

	[JsonProperty("ItemSoulCrystalTarget")]
	public string? ItemSoulCrystalTarget { get; set; }

	[JsonProperty("ItemSoulCrystalTargetID")]
	public int ItemSoulCrystalTargetID { get; set; }

	[JsonProperty("ItemStartingWeapon")]
	public object? ItemStartingWeapon { get; set; }

	[JsonProperty("ItemStartingWeaponTarget")]
	public string? ItemStartingWeaponTarget { get; set; }

	[JsonProperty("ItemStartingWeaponTargetID")]
	public int ItemStartingWeaponTargetID { get; set; }

	[JsonProperty("JobIndex")]
	public int JobIndex { get; set; }

	[JsonProperty("LimitBreak1")]
	public object? LimitBreak1 { get; set; }

	[JsonProperty("LimitBreak1Target")]
	public string? LimitBreak1Target { get; set; }

	[JsonProperty("LimitBreak1TargetID")]
	public int LimitBreak1TargetID { get; set; }

	[JsonProperty("LimitBreak2")]
	public object? LimitBreak2 { get; set; }

	[JsonProperty("LimitBreak2Target")]
	public string? LimitBreak2Target { get; set; }

	[JsonProperty("LimitBreak2TargetID")]
	public int LimitBreak2TargetID { get; set; }

	[JsonProperty("LimitBreak3")]
	public object? LimitBreak3 { get; set; }

	[JsonProperty("LimitBreak3Target")]
	public string? LimitBreak3Target { get; set; }

	[JsonProperty("LimitBreak3TargetID")]
	public int LimitBreak3TargetID { get; set; }

	[JsonProperty("ModifierDexterity")]
	public int ModifierDexterity { get; set; }

	[JsonProperty("ModifierHitPoints")]
	public int ModifierHitPoints { get; set; }

	[JsonProperty("ModifierIntelligence")]
	public int ModifierIntelligence { get; set; }

	[JsonProperty("ModifierManaPoints")]
	public int ModifierManaPoints { get; set; }

	[JsonProperty("ModifierMind")]
	public int ModifierMind { get; set; }

	[JsonProperty("ModifierPiety")]
	public int ModifierPiety { get; set; }

	[JsonProperty("ModifierStrength")]
	public int ModifierStrength { get; set; }

	[JsonProperty("ModifierVitality")]
	public int ModifierVitality { get; set; }

	[JsonProperty("MonsterNote")]
	public object? MonsterNote { get; set; }

	[JsonProperty("MonsterNoteTarget")]
	public string? MonsterNoteTarget { get; set; }

	[JsonProperty("MonsterNoteTargetID")]
	public int MonsterNoteTargetID { get; set; }

	[JsonProperty("Name")]
	public string? Name { get; set; }

	[JsonProperty("NameEnglish")]
	public string? NameEnglish { get; set; }

	[JsonProperty("NameEnglish_de")]
	public string? NameEnglishDe { get; set; }

	[JsonProperty("NameEnglish_en")]
	public string? NameEnglishEn { get; set; }

	[JsonProperty("NameEnglish_fr")]
	public string? NameEnglishFr { get; set; }

	[JsonProperty("NameEnglish_ja")]
	public string? NameEnglishJa { get; set; }

	[JsonProperty("Name_de")]
	public string? NameDe { get; set; }

	[JsonProperty("Name_en")]
	public string? NameEn { get; set; }

	[JsonProperty("Name_fr")]
	public string? NameFr { get; set; }

	[JsonProperty("Name_ja")]
	public string? NameJa { get; set; }

	[JsonProperty("PartyBonus")]
	public int PartyBonus { get; set; }

	[JsonProperty("Prerequisite")]
	public object? Prerequisite { get; set; }

	[JsonProperty("PrerequisiteTarget")]
	public string? PrerequisiteTarget { get; set; }

	[JsonProperty("PrerequisiteTargetID")]
	public int PrerequisiteTargetID { get; set; }

	[JsonProperty("PrimaryStat")]
	public int PrimaryStat { get; set; }

	[JsonProperty("PvPActionSortRow")]
	public int PvPActionSortRow { get; set; }

	[JsonProperty("RelicQuest")]
	public object? RelicQuest { get; set; }

	[JsonProperty("RelicQuestTarget")]
	public string? RelicQuestTarget { get; set; }

	[JsonProperty("RelicQuestTargetID")]
	public int RelicQuestTargetID { get; set; }

	[JsonProperty("Role")]
	public int Role { get; set; }

	[JsonProperty("StartingLevel")]
	public int StartingLevel { get; set; }

	[JsonProperty("StartingTown")]
	public object? StartingTown { get; set; }

	[JsonProperty("StartingTownTarget")]
	public string? StartingTownTarget { get; set; }

	[JsonProperty("StartingTownTargetID")]
	public int StartingTownTargetID { get; set; }

	[JsonProperty("UIPriority")]
	public int UIPriority { get; set; }

	[JsonProperty("UnlockQuest")]
	public object? UnlockQuest { get; set; }

	[JsonProperty("UnlockQuestTarget")]
	public string? UnlockQuestTarget { get; set; }

	[JsonProperty("UnlockQuestTargetID")]
	public int UnlockQuestTargetID { get; set; }
}



