using Xamarin.Forms;

namespace Cost2Meet
{
	public class App
	{
		public static string InsightsKey = "<ADD YOUR KEY HERE>";


		public static Page GetMainPage ()
		{	
			var mainPage = new MainPage ( );
			return new NavigationPage ( mainPage );
		}
	}
}

