using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Items;

public class Item
{
	[JsonProperty("AdditionalData")]
	public int AdditionalData { get; set; }

	[JsonProperty("Adjective")]
	public int Adjective { get; set; }

	[JsonProperty("AetherialReduce")]
	public int AetherialReduce { get; set; }

	[JsonProperty("AlwaysCollectable")]
	public int AlwaysCollectable { get; set; }

	[JsonProperty("Article")]
	public int Article { get; set; }

	[JsonProperty("BaseParam0")]
	public BaseParam? BaseParam0 { get; set; }

	[JsonProperty("BaseParam0Target")]
	public string? BaseParam0Target { get; set; }

	[JsonProperty("BaseParam0TargetID")]
	public int BaseParam0TargetID { get; set; }

	[JsonProperty("BaseParam1")]
	public BaseParam? BaseParam1 { get; set; }

	[JsonProperty("BaseParam1Target")]
	public string? BaseParam1Target { get; set; }

	[JsonProperty("BaseParam1TargetID")]
	public int BaseParam1TargetID { get; set; }

	[JsonProperty("BaseParam2")]
	public BaseParam? BaseParam2 { get; set; }

	[JsonProperty("BaseParam2Target")]
	public string? BaseParam2Target { get; set; }

	[JsonProperty("BaseParam2TargetID")]
	public int BaseParam2TargetID { get; set; }

	[JsonProperty("BaseParam3")]
	public BaseParam? BaseParam3 { get; set; }

	[JsonProperty("BaseParam3Target")]
	public string? BaseParam3Target { get; set; }

	[JsonProperty("BaseParam3TargetID")]
	public int BaseParam3TargetID { get; set; }

	[JsonProperty("BaseParam4")]
	public BaseParam? BaseParam4 { get; set; }

	[JsonProperty("BaseParam4Target")]
	public string? BaseParam4Target { get; set; }

	[JsonProperty("BaseParam4TargetID")]
	public int BaseParam4TargetID { get; set; }

	[JsonProperty("BaseParam5")]
	public BaseParam? BaseParam5 { get; set; }

	[JsonProperty("BaseParam5Target")]
	public string? BaseParam5Target { get; set; }

	[JsonProperty("BaseParam5TargetID")]
	public int BaseParam5TargetID { get; set; }

	[JsonProperty("BaseParamModifier")]
	public int BaseParamModifier { get; set; }

	[JsonProperty("BaseParamSpecial0")]
	public int? BaseParamSpecial0 { get; set; }

	[JsonProperty("BaseParamSpecial0Target")]
	public string? BaseParamSpecial0Target { get; set; }

	[JsonProperty("BaseParamSpecial0TargetID")]
	public int BaseParamSpecial0TargetID { get; set; }

	[JsonProperty("BaseParamSpecial1")]
	public int? BaseParamSpecial1 { get; set; }

	[JsonProperty("BaseParamSpecial1Target")]
	public string? BaseParamSpecial1Target { get; set; }

	[JsonProperty("BaseParamSpecial1TargetID")]
	public int BaseParamSpecial1TargetID { get; set; }

	[JsonProperty("BaseParamSpecial2")]
	public int? BaseParamSpecial2 { get; set; }

	[JsonProperty("BaseParamSpecial2Target")]
	public string? BaseParamSpecial2Target { get; set; }

	[JsonProperty("BaseParamSpecial2TargetID")]
	public int BaseParamSpecial2TargetID { get; set; }

	[JsonProperty("BaseParamSpecial3")]
	public int? BaseParamSpecial3 { get; set; }

	[JsonProperty("BaseParamSpecial3Target")]
	public string? BaseParamSpecial3Target { get; set; }

	[JsonProperty("BaseParamSpecial3TargetID")]
	public int BaseParamSpecial3TargetID { get; set; }

	[JsonProperty("BaseParamSpecial4")]
	public int? BaseParamSpecial4 { get; set; }

	[JsonProperty("BaseParamSpecial4Target")]
	public string? BaseParamSpecial4Target { get; set; }

	[JsonProperty("BaseParamSpecial4TargetID")]
	public int BaseParamSpecial4TargetID { get; set; }

	[JsonProperty("BaseParamSpecial5")]
	public int? BaseParamSpecial5 { get; set; }

	[JsonProperty("BaseParamSpecial5Target")]
	public string? BaseParamSpecial5Target { get; set; }

	[JsonProperty("BaseParamSpecial5TargetID")]
	public int BaseParamSpecial5TargetID { get; set; }

	[JsonProperty("BaseParamValue0")]
	public int BaseParamValue0 { get; set; }

	[JsonProperty("BaseParamValue1")]
	public int BaseParamValue1 { get; set; }

	[JsonProperty("BaseParamValue2")]
	public int BaseParamValue2 { get; set; }

	[JsonProperty("BaseParamValue3")]
	public int BaseParamValue3 { get; set; }

	[JsonProperty("BaseParamValue4")]
	public int BaseParamValue4 { get; set; }

	[JsonProperty("BaseParamValue5")]
	public int BaseParamValue5 { get; set; }

	[JsonProperty("BaseParamValueSpecial0")]
	public int BaseParamValueSpecial0 { get; set; }

	[JsonProperty("BaseParamValueSpecial1")]
	public int BaseParamValueSpecial1 { get; set; }

	[JsonProperty("BaseParamValueSpecial2")]
	public int BaseParamValueSpecial2 { get; set; }

	[JsonProperty("BaseParamValueSpecial3")]
	public int BaseParamValueSpecial3 { get; set; }

	[JsonProperty("BaseParamValueSpecial4")]
	public int BaseParamValueSpecial4 { get; set; }

	[JsonProperty("BaseParamValueSpecial5")]
	public int BaseParamValueSpecial5 { get; set; }

	[JsonProperty("Block")]
	public int Block { get; set; }

	[JsonProperty("BlockRate")]
	public int BlockRate { get; set; }

	[JsonProperty("CanBeHq")]
	public int CanBeHq { get; set; }

	[JsonProperty("ClassJobCategory")]
	public ClassJobCategory? ClassJobCategory { get; set; }

	[JsonProperty("ClassJobCategoryTarget")]
	public string? ClassJobCategoryTarget { get; set; }

	[JsonProperty("ClassJobCategoryTargetID")]
	public int ClassJobCategoryTargetID { get; set; }

	[JsonProperty("ClassJobRepair")]
	public ClassJobRepair? ClassJobRepair { get; set; }

	[JsonProperty("ClassJobRepairTarget")]
	public string? ClassJobRepairTarget { get; set; }

	[JsonProperty("ClassJobRepairTargetID")]
	public int ClassJobRepairTargetID { get; set; }

	[JsonProperty("ClassJobUse")]
	public int? ClassJobUse { get; set; }

	[JsonProperty("ClassJobUseTarget")]
	public string? ClassJobUseTarget { get; set; }

	[JsonProperty("ClassJobUseTargetID")]
	public int ClassJobUseTargetID { get; set; }

	[JsonProperty("CooldownS")]
	public int CooldownS { get; set; }

	[JsonProperty("DamageMag")]
	public int DamageMag { get; set; }

	[JsonProperty("DamagePhys")]
	public int DamagePhys { get; set; }

	[JsonProperty("DefenseMag")]
	public int DefenseMag { get; set; }

	[JsonProperty("DefensePhys")]
	public int DefensePhys { get; set; }

	[JsonProperty("DelayMs")]
	public int DelayMs { get; set; }

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

	[JsonProperty("Desynth")]
	public int Desynth { get; set; }

	[JsonProperty("EquipRestriction")]
	public int EquipRestriction { get; set; }

	[JsonProperty("EquipSlotCategory")]
	public EquipSlotCategory? EquipSlotCategory { get; set; }

	[JsonProperty("EquipSlotCategoryTarget")]
	public string? EquipSlotCategoryTarget { get; set; }

	[JsonProperty("EquipSlotCategoryTargetID")]
	public int EquipSlotCategoryTargetID { get; set; }

	[JsonProperty("FilterGroup")]
	public int FilterGroup { get; set; }

	[JsonProperty("GrandCompany")]
	public int? GrandCompany { get; set; }

	[JsonProperty("GrandCompanyTarget")]
	public string? GrandCompanyTarget { get; set; }

	[JsonProperty("GrandCompanyTargetID")]
	public int GrandCompanyTargetID { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }

	[JsonProperty("Icon")]
	public string? Icon { get; set; }

	[JsonProperty("IconHD")]
	public string? IconHD { get; set; }

	[JsonProperty("IconID")]
	public int IconID { get; set; }

	[JsonProperty("IsAdvancedMeldingPermitted")]
	public int IsAdvancedMeldingPermitted { get; set; }

	[JsonProperty("IsCollectable")]
	public int IsCollectable { get; set; }

	[JsonProperty("IsCrestWorthy")]
	public int IsCrestWorthy { get; set; }

	[JsonProperty("IsDyeable")]
	public int IsDyeable { get; set; }

	[JsonProperty("IsGlamourous")]
	public int IsGlamourous { get; set; }

	[JsonProperty("IsIndisposable")]
	public int IsIndisposable { get; set; }

	[JsonProperty("IsPvP")]
	public int IsPvP { get; set; }

	[JsonProperty("IsUnique")]
	public int IsUnique { get; set; }

	[JsonProperty("IsUntradable")]
	public int IsUntradable { get; set; }

	[JsonProperty("ItemAction")]
	public int? ItemAction { get; set; }

	[JsonProperty("ItemActionTarget")]
	public string? ItemActionTarget { get; set; }

	[JsonProperty("ItemActionTargetID")]
	public int ItemActionTargetID { get; set; }

	[JsonProperty("ItemGlamour")]
	public ItemGlamour? ItemGlamour { get; set; }

	[JsonProperty("ItemGlamourTarget")]
	public string? ItemGlamourTarget { get; set; }

	[JsonProperty("ItemGlamourTargetID")]
	public int ItemGlamourTargetID { get; set; }

	[JsonProperty("ItemRepair")]
	public ItemRepair? ItemRepair { get; set; }

	[JsonProperty("ItemRepairTarget")]
	public string? ItemRepairTarget { get; set; }

	[JsonProperty("ItemRepairTargetID")]
	public int ItemRepairTargetID { get; set; }

	[JsonProperty("ItemSearchCategory")]
	public int? ItemSearchCategory { get; set; }

	[JsonProperty("ItemSearchCategoryTarget")]
	public string? ItemSearchCategoryTarget { get; set; }

	[JsonProperty("ItemSearchCategoryTargetID")]
	public int ItemSearchCategoryTargetID { get; set; }

	[JsonProperty("ItemSeries")]
	public int? ItemSeries { get; set; }

	[JsonProperty("ItemSeriesTarget")]
	public string? ItemSeriesTarget { get; set; }

	[JsonProperty("ItemSeriesTargetID")]
	public int ItemSeriesTargetID { get; set; }

	[JsonProperty("ItemSortCategory")]
	public ItemSortCategory? ItemSortCategory { get; set; }

	[JsonProperty("ItemSortCategoryTarget")]
	public string? ItemSortCategoryTarget { get; set; }

	[JsonProperty("ItemSortCategoryTargetID")]
	public int ItemSortCategoryTargetID { get; set; }

	[JsonProperty("ItemSpecialBonus")]
	public int? ItemSpecialBonus { get; set; }

	[JsonProperty("ItemSpecialBonusParam")]
	public int ItemSpecialBonusParam { get; set; }

	[JsonProperty("ItemSpecialBonusTarget")]
	public string? ItemSpecialBonusTarget { get; set; }

	[JsonProperty("ItemSpecialBonusTargetID")]
	public int ItemSpecialBonusTargetID { get; set; }

	[JsonProperty("ItemUICategory")]
	public ItemUICategory? ItemUICategory { get; set; }

	[JsonProperty("ItemUICategoryTarget")]
	public string? ItemUICategoryTarget { get; set; }

	[JsonProperty("ItemUICategoryTargetID")]
	public int ItemUICategoryTargetID { get; set; }

	[JsonProperty("LevelEquip")]
	public int LevelEquip { get; set; }

	[JsonProperty("LevelItem")]
	public int LevelItem { get; set; }

	[JsonProperty("Lot")]
	public int Lot { get; set; }

	[JsonProperty("MateriaSlotCount")]
	public int MateriaSlotCount { get; set; }

	[JsonProperty("MaterializeType")]
	public int MaterializeType { get; set; }

	[JsonProperty("ModelMain")]
	public string? ModelMain { get; set; }

	[JsonProperty("ModelSub")]
	public string? ModelSub { get; set; }

	[JsonProperty("Name")]
	public string? Name { get; set; }

	[JsonProperty("Name_de")]
	public string? NameDe { get; set; }

	[JsonProperty("Name_en")]
	public string? NameEn { get; set; }

	[JsonProperty("Name_fr")]
	public string? NameFr { get; set; }

	[JsonProperty("Name_ja")]
	public string? NameJa { get; set; }

	[JsonProperty("Plural")]
	public string? Plural { get; set; }

	[JsonProperty("Plural_de")]
	public string? PluralDe { get; set; }

	[JsonProperty("Plural_en")]
	public string? PluralEn { get; set; }

	[JsonProperty("Plural_fr")]
	public string? PluralFr { get; set; }

	[JsonProperty("Plural_ja")]
	public string? PluralJa { get; set; }

	[JsonProperty("PossessivePronoun")]
	public int PossessivePronoun { get; set; }

	[JsonProperty("PriceLow")]
	public int PriceLow { get; set; }

	[JsonProperty("PriceMid")]
	public int PriceMid { get; set; }

	[JsonProperty("Pronoun")]
	public int Pronoun { get; set; }

	[JsonProperty("Rarity")]
	public int Rarity { get; set; }

	[JsonProperty("Singular")]
	public string? Singular { get; set; }

	[JsonProperty("Singular_de")]
	public string? SingularDe { get; set; }

	[JsonProperty("Singular_en")]
	public string? SingularEn { get; set; }

	[JsonProperty("Singular_fr")]
	public string? SingularFr { get; set; }

	[JsonProperty("Singular_ja")]
	public string? SingularJa { get; set; }

	[JsonProperty("StackSize")]
	public int StackSize { get; set; }

	[JsonProperty("StartsWithVowel")]
	public int StartsWithVowel { get; set; }
}



