using Xamarin.Forms;
using SQLite.Net.Interop;

namespace Cost2Meet
{
	public class App
	{
		public static readonly string InsightsKey = "<ADD YOUR KEY HERE>";
		public static readonly string DatabaseName = "cost2meet.db3";

		public static Cost2MeetRepository Cost2MeetRepository { get; private set; }


		public static Page GetMainPage (ISQLitePlatform sqlitePlatform, string dbFilePath)
		{	
			Cost2MeetRepository = new Cost2MeetRepository ( sqlitePlatform, dbFilePath );

			var mainPage = new MainPage ( );
			return new NavigationPage ( mainPage );
		}
	}
}

