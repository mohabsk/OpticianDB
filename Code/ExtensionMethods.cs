using System;
using System.ComponentModel;

namespace OpticianDB.Extensions
{
	/// <summary>
	/// Description of ExtensionMethods.
	/// </summary>
	public static class GenericExtension
	{
		public static T? GetValueOrNull<T>(this string valueAsString)
			where T : struct
		{
			if (string.IsNullOrEmpty(valueAsString))
				return null;
			return (T) Convert.ChangeType(valueAsString, typeof(T));
		}
		public static T? GetValueOrNull<T>(this object valueAsObjectString)
			where T : struct
		{
			if (valueAsObjectString == null || string.IsNullOrEmpty(valueAsObjectString.ToString()))
				return null;
			return (T) Convert.ChangeType(valueAsObjectString.ToString(), typeof(T));
		}
	}
}
