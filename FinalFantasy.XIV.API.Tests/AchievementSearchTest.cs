using System.Threading.Tasks;
using FinalFantasy.XIV.API.Models.Search.Achievements;
using FinalFantasy.XIV.API.Services.Config;
using FinalFantasy.XIV.API.Services.Search;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;

namespace FinalFantasy.XIV.API.Tests;

[TestClass]
public class AchievementSearchTest
{


	private string Host { get; }

	private string PrivateKey { get; }

	private ISearchApi Client { get; }

	public AchievementSearchTest()
	{
		var config = new ConfigHelper();

		Host = config.Host;
		PrivateKey = config.PrivateKey;
		var refitSettings = RefitSettingFactory.CreateSettings();
		Client = RestService.For<ISearchApi>(Host, refitSettings);
	}

	[TestMethod]
	public async Task AchievementSearchTests_MatchAllSearchAchievements()
	{

		var request = new Models.Search.SearchRequest<object>
		{
			Indexes = "achievement",
			Columns = "*",
			Body = new object()
		};


		var response = await Client.SearchAsync<Achievement, object>(request, PrivateKey);

		response.Results.Should().NotBeNull().And.Contain(x => x.AchievementTarget != null);
	}

	[TestMethod]
	[Ignore]
	public async Task AchievementSearchTests_SelectRelevantColumns()
	{
		//var apiBody = new ApiBody
		//{
		//	Indexes = "achievement",
		//	Columns = "AchievementCategory.AchievementKind.ID,AchievementCategory.AchievementKind.Name,AchievementCategory.ID,AchievementCategory.Name,GamePatch.ID,GamePatch.Name,GamePatch.ReleaseDate,GamePatch.Version,ID,Name,Description,IconHD",
		//	Body = new object()
		//};

		//var result = await Client.SearchAsync(apiBody);
		await Task.CompletedTask;
	}

}
