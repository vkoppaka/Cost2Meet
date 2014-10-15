using System;
using System.IO;

namespace Cost2Meet.Android
{
	public static class DatabaseFilePathRetriever
	{
		public static string Get(string fileName)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return Path.Combine(path, fileName);
		}
	}
}

