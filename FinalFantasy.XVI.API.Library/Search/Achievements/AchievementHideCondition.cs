using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FinalFantasy.XIV.API.Models.Search.Achievements;

public class AchievementHideCondition
{
	[JsonProperty("HideAchievement")]
	public int HideAchievement { get; set; }

	[JsonProperty("HideConditions")]
	public int HideConditions { get; set; }

	[JsonProperty("HideName")]
	public int HideName { get; set; }

	[JsonProperty("ID")]
	public int ID { get; set; }
}

