using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace FinalFantasy.XIV.API.Tests;

internal class ConfigHelper
{

	public ConfigHelper()
	{
		Configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json", true, true)
			.AddUserSecrets(Assembly.GetAssembly(typeof(ConfigHelper)))
			.AddEnvironmentVariables()
			.Build();
	}
	private IConfigurationRoot Configuration { get; }

	public string PrivateKey => Configuration["XIVAPI:PrivateKey"];
	public string Host => Configuration["XIVAPI:Host"];
}
