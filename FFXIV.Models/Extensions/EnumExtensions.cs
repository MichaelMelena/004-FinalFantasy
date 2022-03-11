using System.ComponentModel;
using System.Reflection;

namespace FFXIV.Models.Extensions;

public static class EnumExtensions
{
	public static string? GetDescription<TEnum>(this TEnum value) where TEnum : struct, Enum
	{
		Type type = value.GetType();
		string? name = Enum.GetName(type, value);
		if (name != null)
		{
			FieldInfo? field = type.GetField(name);
			if (field != null)
			{
				if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attr)
				{
					return attr.Description;
				}
			}
		}
		return null;
	}
}
