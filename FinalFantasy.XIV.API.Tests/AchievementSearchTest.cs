using System.Collections.Generic;
using System.Threading.Tasks;
using FinalFantasy.XIV.API.Models.Search.Achievements;
using FinalFantasy.XIV.API.Services.Config;
using FinalFantasy.XIV.API.Services.Search;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;
using Newtonsoft.Json;
using Elasticsearch.Net;
using Nest;
using System;
using System.Dynamic;

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
	public async Task AchievementSearchTests_FilterAchievements()
	{

		//DICT notation
		object json = "{ \"query\": { \"bool\": { \"filter\": [{ \"match\": { \"ID\": 1 } }] } } }";
		object dict = new Dictionary<string, object>
		{
			{
				"query", new Dictionary<string, object>
				{
					{
						"bool", new Dictionary<string, object>
						{
							{
								"filter", new List<object>
								{
									new Dictionary<string, object>
									{
										{
											"match", new Dictionary<string, object>
											{
												{ "ID", 1 }
											}
										}
									}
								}
							}
						}
					}
				}
			}
		};

		//Dynamic notation
		dynamic filter = new ExpandoObject();
		filter.match = new Dictionary<string, int>
		{
			{ "ID", 1 }
		};

		dynamic data = new ExpandoObject();
		data.query = new ExpandoObject();
		data.query.@bool = new ExpandoObject();
		data.query.@bool = new ExpandoObject();

		data.query.@bool.filter = new ExpandoObject[]
		{
			filter
		};

		var objectData = new
		{
			query = new
			{
				@bool = new
				{
					filter = new[]
					{
						new
						{
							match = new { ID = 1 }
						}
					}
				}
			}
		};

		var node = new Uri(Host);
		var connection = new ConnectionSettings(node);
		var tmpClient = new ElasticClient(connection);

		var tmpResponse = tmpClient.Search<Achievement>(x => x.Index("achievement"));

		var tmpA = JsonConvert.SerializeObject(json);
		var tmpB = JsonConvert.SerializeObject(dict);
		var tmpC = JsonConvert.SerializeObject(data);
		var tmpD = JsonConvert.SerializeObject(objectData);

		var request = new Models.Search.SearchRequest<object>
		{
			Indexes = "achievement",
			Columns = "*",
			Body = (object)objectData
		};

		var response = await Client.SearchAsync<Achievement, object>(request, PrivateKey);

		response.Results.Should().NotBeNull().And.HaveCount(1);
	}

	[TestMethod]
	[Microsoft.VisualStudio.TestTools.UnitTesting.Ignore]
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
