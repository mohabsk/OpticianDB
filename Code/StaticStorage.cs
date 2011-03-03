using System;

namespace OpticianDB
{
	public static class StaticStorage
	{
		private static string _userName;

		public static string UserName
		{
			get { return _userName; }
			set { _userName = value; }
		}
	}
}
