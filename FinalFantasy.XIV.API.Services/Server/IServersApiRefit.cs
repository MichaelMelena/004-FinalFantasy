using FinalFantasy.XIV.API.Models.GameData.Servers;
using Refit;

namespace FinalFantasy.XIV.API.Services.Server;

public interface IServersApiRefit
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="privateKey">API Key</param>
    /// <returns>List of server names</returns>
    [Get("/servers")]
    Task<ServersResponse> ServersAsync([AliasAs("private_key")] string privateKey);

	/// <summary>
	/// 
	/// </summary>
	/// <param name="privateKey"></param>
	/// <returns>List of servers grouped by data center</returns>
	[Get("/servers/dc")]
	Task<ServersByDataCenterResponse> ServersByDataCenterAsync([AliasAs("private_key")] string privateKey);
}

