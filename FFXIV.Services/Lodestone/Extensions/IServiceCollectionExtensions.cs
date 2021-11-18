using FFXIV.Services.Lodestone.Http;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace FFXIV.Services.Lodestone.Extensions;

public static class IServiceCollectionExtensions
{
	public static IServiceCollection AddLodestoneService(this IServiceCollection services)
	{
		services.AddRefitClient<ILodestoneCharacterProfileApi>().ConfigureHttpClient(x =>
		{
			x.BaseAddress = new Uri("https://eu.finalfantasyxiv.com");

		});

		services.AddScoped<ICharacterProfileParser, CharacterProfileParser>();

		return services;
	}
}
