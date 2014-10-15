using System;
using System.IO;

namespace Cost2Meet.iOS
{
	public static class DatabaseFilePathRetriever
	{
		public static string Get(string fileName)
		{
			string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

			if (!Directory.Exists(libFolder))
			{
				Directory.CreateDirectory(libFolder);
			}

			return Path.Combine(libFolder, fileName); 
		}
	}
}

