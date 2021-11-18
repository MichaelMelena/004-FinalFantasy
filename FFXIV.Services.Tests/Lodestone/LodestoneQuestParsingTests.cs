using System.Threading.Tasks;
using FFXIV.Services.Lodestone;
using FFXIV.Services.Lodestone.Http;
using HtmlAgilityPack;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;

namespace FFXIV.Services.Tests.Lodestone;

[TestClass]
public class LodestoneQuestParsingTests
{
	[TestMethod]
	public async Task Test()
	{
		var api = RestService.For<ILodestoneCharacterProfileApi>("https://eu.finalfantasyxiv.com");
		var characterParser = new CharacterProfileParser(api);

		var profile = await characterParser.GetProfileAsync("28632101");
	}
}
