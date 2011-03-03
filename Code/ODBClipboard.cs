using System;
using System.Windows.Forms;
namespace OpticianDB
{
	/// <summary>
	/// Description of Clipboard.
	/// </summary>
	public static class ODBClipboard
	{
		public static void SetClipboardText(string input)
		{
			Clipboard.SetText(input);
		}
		public static string GetClipboardText()
		{
			if (Clipboard.ContainsText())
			{
				return Clipboard.GetText();
			}
			return "";
		}
	}
}
