using System;
using System.Security.Cryptography;
using System.Text;

namespace OpticianDB
{
	/// <summary>
	/// Description of Hashing.
	/// </summary>
	internal static class Hashing
	{
		internal static string getMd5Hash(string input)
		{
			byte[] data;
			using (MD5 md5Hasher = MD5.Create())
			{
				data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
			}
			
			StringBuilder sBuilder = new StringBuilder();


			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			return sBuilder.ToString();
		}

		internal static string SHA1Hash(string input)
		{
			byte[] data;
			using (SHA1 sha1Hasher = SHA1.Create())
			{
				data = sha1Hasher.ComputeHash(Encoding.Default.GetBytes(input));
			}
			
			StringBuilder sBuilder = new StringBuilder();


			for (int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			return sBuilder.ToString();
		}
		
		internal static string GetHash(string input, string method)
		{
			switch (method) {
				case "md5":
					return getMd5Hash(input);
				case "sha1":
					return SHA1Hash(input);
				default:
					return input;
			}
		}
	}
}
