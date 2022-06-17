using System;
namespace FFXIV.Models.Search;

public record class ProfileSearchRequest
{
	public string? Name { get; set; }
	public Language Language { get; set; }
	public DataCenter DataCenter { get; set; }
	public HomeWorld HomeWorld { get; set; }
}

