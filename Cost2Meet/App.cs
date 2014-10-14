using Xamarin.Forms;

namespace Cost2Meet
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			var mainPage = new MainPage ( );
			return new NavigationPage ( mainPage );
		}
	}
}

