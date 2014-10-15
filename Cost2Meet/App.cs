using Xamarin.Forms;
using SQLite.Net.Interop;

namespace Cost2Meet
{
	public class App
	{
		public static readonly string InsightsKey = "<ADD YOUR KEY HERE>";
		public static readonly string DatabaseName = "cost2meet.db3";


		public static Page GetMainPage (ISQLitePlatform sqlitePlatform, string dbFilePath)
		{	
			var mainPage = new MainPage ( );
			return new NavigationPage ( mainPage );
		}
	}
}

