using Refit;

namespace FinalFantasy.XIV.API.Services.Config;

public static class RefitSettingFactory
{
	public static RefitSettings CreateSettings()
	{
		return new RefitSettings
		{
			ContentSerializer = new NewtonsoftJsonContentSerializer(
			new Newtonsoft.Json.JsonSerializerSettings
			{
				Culture = System.Globalization.CultureInfo.InvariantCulture
			})
		};
	}
}
