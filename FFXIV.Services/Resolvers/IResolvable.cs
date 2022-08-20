namespace FFXIV.Services.Resolvers;

public interface IResolvable<T>
{
	Task<string> GetContentAsync();
}

